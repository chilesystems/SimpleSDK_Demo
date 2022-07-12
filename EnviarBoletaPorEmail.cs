using System;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.BHE;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class EnviarBoletaPorEmail : Form
    {
        Helper handler = new Helper();
        public EnviarBoletaPorEmail()
        {
            InitializeComponent();
        }

        private void EnviarBoletaPorEmail_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextbox.Text = handler.Configuracion.Certificado.Rut;
        }

        private async void EnviarEmailButton_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(EnviarEmailButton);
            try
            {
                var folio = int.Parse(FolioTextbox.Text);
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Password;
                var apikey = handler.Configuracion.APIKey;
                var correo = CorreoTextBox.Text;
                var anio = int.Parse(AnioTextbox.Text);
                var input = new BHData
                {
                    RutCertificado =  rutUsuario,
                    Password = password,
                    CertificadoB64 = certificado,
                    Correo = correo
                };
                var (boletaEnviada, message) = await BHHelper.EnviarEmail(input, folio, apikey, anio);
                if (boletaEnviada)
                {
                    var buttons = MessageBoxButtons.OK;
                    var caption = "Envío de Boletas de Honorarios";
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(message);
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Loading.HideLoading(EnviarEmailButton);
        }
    }
}