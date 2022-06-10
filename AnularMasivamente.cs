using System;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.Folios;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class AnularMasivamente : Form
    {
        Helper handler = new Helper();
        public AnularMasivamente()
        {
            InitializeComponent();
        }

        private void AnularMasivamente_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextBox.Text = handler.Configuracion.Empresa.RutEmpresa;
            RutEmisorTextBox.Enabled = false;
        }

        private async void AnularButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rutEmisor = RutEmisorTextBox.Text;
                var tipoDte = int.Parse(TipoDteTextBox.Text);
                var desde = int.Parse(FolioDesdeTextBox.Text);
                var hasta = int.Parse(FolioHastaTextBox.Text);
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Rut;
                var apikey = handler.Configuracion.APIKey;
                var input = new FoliosData
                {
                    RutCertificado =  rutUsuario,
                    Password = password,
                    RutEmpresa = rutEmisor,
                    Ambiente = 0,
                    CertificadoB64 = certificado,
                    Tipo = tipoDte,
                };
                var (anulacionExitosa, message) = await FoliosHelper.AnulacionMasiva(desde, hasta, input, apikey);
                var buttons = MessageBoxButtons.OK;
                var messageBoxMessage = "";
                var caption = "Resultado Anulación de Folios";
                if (anulacionExitosa)
                {
                    messageBoxMessage = "Anulación completada con éxito";
                }
                else
                {
                    messageBoxMessage = "No se pudo completar la operación";
                }
                MessageBox.Show(messageBoxMessage, caption, buttons);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}