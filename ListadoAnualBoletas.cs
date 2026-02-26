using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using SimpleSDK.Helpers;
using SimpleSDK.Models.BHE;
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
            RutEmisorTextbox.Text = handler.Configuracion.UsuarioSII.RutUsuario;
            numericAnio.Value = DateTime.Now.Year;
        }

        private async void ListadoButton_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(gridResultados);
            ListadoButton.Enabled = false; 
            try
            {
                string tipo = "";
                if (RecibidaRadioButton.Checked)
                    tipo = "recibidas";
                else if (EmitidaRadioButton.Checked)
                    tipo = "emitidas";
                //var rutUsuario = RutEmisorTextbox.Text;
                //var password = handler.Configuracion.UsuarioSII.PasswordSII;
                var apikey = handler.Configuracion.APIKey;
                var anio = (int)numericAnio.Value;
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var rutCertificado = handler.Configuracion.Certificado.Rut;
                var passwordCertificado = handler.Configuracion.Certificado.Password;

                byte[] certBytes = System.IO.File.ReadAllBytes(rutaCertificado);
                string nombreCertificado = System.IO.Path.GetFileName(rutaCertificado);
                var basicData = new BHData
                {
                    //RutUsuario =  rutUsuario,
                    //PasswordSII = password
                    CertificadoB64 = certBytes,
                    Password = passwordCertificado,
                    RutCertificado = rutCertificado,
                };
                var resumenAnual = await BHHelper.ObtenerListadoAnualAsync(basicData, tipo, anio, apikey, nombreCertificado);
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