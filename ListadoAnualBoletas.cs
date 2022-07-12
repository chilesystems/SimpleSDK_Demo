using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using SimpleSDK.Helpers;
using SimpleSDK.Models.RegistroCompraVentas;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class ListadoAnualBoletas : Form
    {
        Helper handler = new Helper();
        public ListadoAnualBoletas()
        {
            InitializeComponent();
        }

        private void ListadoAnualBoletas_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextbox.Text = handler.Configuracion.Certificado.Rut;
            numericAnio.Value = DateTime.Now.Year;
        }

        private async void ListadoButton_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(gridResultados);
            ListadoButton.Enabled = false; 
            try
            {
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                string tipo = "";
                if (RecibidaRadioButton.Checked)
                    tipo = "recibidas";
                else if (EmitidaRadioButton.Checked)
                    tipo = "emitidas";
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Password;
                var apikey = handler.Configuracion.APIKey;
                var anio = (int)numericAnio.Value;
                var basicData = new BasicData
                {
                    RutCertificado =  rutUsuario,
                    Password = password,
                    CertificadoB64 = certificado
                };
                var resumenAnual = await BHHelper.ObtenerListadoAnualAsync(basicData, tipo, anio, apikey);
                gridResultados.AutoGenerateColumns = true;
                gridResultados.DataSource = null;
                gridResultados.DataSource = resumenAnual.Periodos;

                TotalHonorarioBrutoValorLabel.Text = resumenAnual.TotalHonorarioBruto.ToString("N0");
                TotalVigentesValorLabel.Text = resumenAnual.TotalVigentes.ToString("N0");
                TotalAnuladasValorLabel.Text = resumenAnual.TotalAnuladas.ToString("N0");
                RetencionContribuyentesValorLabel.Text = resumenAnual.TotalRetencionContribuyente.ToString("N0");
                RetencionLiquidoValorLabel.Text = resumenAnual.TotalRetencionLiquido.ToString("N0");
                RetencionTercerosValorLabel.Text = resumenAnual.TotalRetencionTerceros.ToString("N0");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            Loading.HideLoading(gridResultados);
            ListadoButton.Enabled = true;
        }
    }
}