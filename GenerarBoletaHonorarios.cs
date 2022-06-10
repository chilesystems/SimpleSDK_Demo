using System;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.BHE;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class GenerarBoletaHonorarios : Form
    {
        Helper handler = new Helper();
        public GenerarBoletaHonorarios()
        {
            InitializeComponent();
        }

        private void GenerarBoletaHonorarios_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextBox.Text = handler.Configuracion.Certificado.Rut;
            RutEmisorTextBox.Enabled = false;
        }

        private async void GenerarBoletaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rutEmisor = RutEmisorTextBox.Text;
                var rutReceptor = RutReceptorTextbox.Text;
                var correo = CorreoTextBox.Text;
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Rut;
                TipoRetencionEnum tipoRetencion = RetencionContribuyenteRadioButton.Checked
                    ? TipoRetencionEnum.Contribuyente
                    : TipoRetencionEnum.Receptor;
                var apikey = handler.Configuracion.APIKey;
                // todo detalles y receptor
                var input = new BHData
                {
                    RutCertificado =  rutUsuario,
                    Password = password,
                    CertificadoB64 = certificado,
                    RutEmisor = rutEmisor,
                    Correo = correo,
                    Retencion = tipoRetencion,
                    FechaEmision = DateTime.Today,
                    Detalles = null,
                    Receptor = null
                };
                var (emisionExitosa, message) = await BHHelper.EmitirAsync(input, apikey);
                if (emisionExitosa)
                {
                    var buttons = MessageBoxButtons.OK;
                    var messageBoxMessage = "Se emitió correctamente la boleta de honorarios";
                    var caption = "Resultado Generación de Boletas de Honorarios";
                    MessageBox.Show(messageBoxMessage, caption, buttons);
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}