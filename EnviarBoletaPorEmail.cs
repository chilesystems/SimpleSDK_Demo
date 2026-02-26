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
            RutEmisorTextbox.Text = handler.Configuracion.UsuarioSII.RutUsuario;
        }

        private async void EnviarEmailButton_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(EnviarEmailButton);
            try
            {
                var folio = int.Parse(FolioTextbox.Text);
               // var rutUsuario = RutEmisorTextbox.Text;
                //var password = handler.Configuracion.UsuarioSII.PasswordSII;
                var apikey = handler.Configuracion.APIKey;
                var correo = CorreoTextBox.Text;
                var anio = int.Parse(AnioTextbox.Text);
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var rutCertificado = handler.Configuracion.Certificado.Rut;
                var passwordCertificado = handler.Configuracion.Certificado.Password;

                byte[] certBytes = System.IO.File.ReadAllBytes(rutaCertificado);
                string nombreCertificado = System.IO.Path.GetFileName(rutaCertificado);
                var input = new BHData
                {
                    //RutUsuario =  rutUsuario,
                    //PasswordSII = password,
                    Correo = correo,
                    CertificadoB64 = certBytes,
                    Password = passwordCertificado,
                    RutCertificado = rutCertificado,
                };
                var (boletaEnviada, message) = await BHHelper.EnviarEmail(input, folio, apikey, anio, nombreCertificado);
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