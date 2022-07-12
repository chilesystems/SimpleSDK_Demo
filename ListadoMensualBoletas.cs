using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using SimpleSDK.Helpers;
using SimpleSDK.Models.RegistroCompraVentas;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class ListadoMensualBoletas : Form
    {
        Helper handler = new Helper();
        public ListadoMensualBoletas()
        {
            InitializeComponent();
        }

        private void ListadoMensualBoletas_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextbox.Text = handler.Configuracion.Certificado.Rut;
            RutEmisorTextbox.Enabled = false;
            numericAnio.Value = DateTime.Now.Year;
            numericMes.Value = DateTime.Now.Month;
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
                {
                    tipo = "recibidas";
                    RazonSocialEmisorColumn.Visible = RutEmisorColumn.Visible = true;
                    RazonSocialReceptorColumn.Visible = RutReceptorColumn.Visible = false;
                }
                else if (EmitidaRadioButton.Checked)
                {
                    RazonSocialEmisorColumn.Visible = RutEmisorColumn.Visible = false;
                    RazonSocialReceptorColumn.Visible = RutReceptorColumn.Visible = true;
                    tipo = "emitidas";
                }
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Password;
                var apikey = handler.Configuracion.APIKey;
                var mes = (int)numericMes.Value;
                var anio = (int) numericAnio.Value;
                var basicData = new BasicData
                {
                    RutCertificado =  rutUsuario,
                    Password = password,
                    CertificadoB64 = certificado
                };
                var resumenMensual = await BHHelper.ObtenerListadoMensualAsync(basicData, tipo, anio, mes, apikey);
                gridResultados.AutoGenerateColumns = false;
                gridResultados.DataSource = null;
                gridResultados.DataSource = resumenMensual.Boletas;
                TotalBrutoValorLabel.Text = resumenMensual.TotalBruto.ToString("N0");
                TotalLiquidoValorLabel.Text = resumenMensual.TotalLiquido.ToString("N0");
                TotalPagadoValorLabel.Text = resumenMensual.TotalPagado.ToString("N0");
                TotalRetencionEmisorValorLabel.Text = resumenMensual.TotalRetencionEmisor.ToString("N0");
                TotalRetencionReceptorValorLabel.Text = resumenMensual.TotalRetencionReceptor.ToString("N0");
                TotalRetenidoValorLabel.Text = resumenMensual.TotalRetenido.ToString("N0");
                CantidadDocumentosValorLabel.Text = resumenMensual.CantidadDocumentos.ToString("N0");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Loading.HideLoading(gridResultados);
            ListadoButton.Enabled = true;
        }
    }
}