using System;
using System.Net.Http;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.Folios;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class ConsultarMaximoFolios : Form
    {
        Helper handler = new Helper();
        public ConsultarMaximoFolios()
        {
            InitializeComponent();
        }
        
        private async void ConsultarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rutEmisor = RutEmisorTextBox.Text;
                var tipoDte = int.Parse(TipoDteTextBox.Text);
                int ambiente = 0;
                if (AmbienteProducciónRadioButton.Checked)
                    ambiente = 0;
                
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Rut;
                var apikey = handler.Configuracion.APIKey;
                var input = new FoliosData
                {
                    RutCertificado = rutUsuario,
                    Password = password,
                    RutEmpresa = rutEmisor,
                    Ambiente = ambiente,
                    CertificadoB64 = certificado,
                    Tipo = tipoDte,
                };
                
                var (hasResponse, message, maximoFolios) = await FoliosHelper.ConsultarMaximoFoliosDisponibles(input, apikey, new WinHttpHandler());
                if (hasResponse)
                {
                    var buttons = MessageBoxButtons.OK;
                    var messageBoxMessage = $"Puede solicitar un máximo de {maximoFolios} para DTEs de tipo {tipoDte}";
                    var caption = "Resultado Consulta";
                    MessageBox.Show(messageBoxMessage, caption, buttons);
                }
                else
                {
                    var buttons = MessageBoxButtons.OK;
                    var messageBoxMessage = message;
                    var caption = "Resultado Consulta";
                    MessageBox.Show(messageBoxMessage, caption, buttons);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + Environment.NewLine + exception.InnerException?.Message ?? "");
            }
        }

        private void ConsultarMaximoFolios_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextBox.Text = handler.Configuracion.Empresa.RutEmpresa;
            RutEmisorTextBox.Enabled = false;
        }
    }
}