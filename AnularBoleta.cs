using System;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.BHE;
using SimpleSDK.Models.RegistroCompraVentas;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class AnularBoleta : Form
    {
        Helper handler = new Helper();
        public AnularBoleta()
        {
            InitializeComponent();
        }


        private void AnularBoleta_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextBox.Text = handler.Configuracion.Certificado.Rut;
            RutEmisorTextBox.Enabled = false;
        }

        private async void AnulaButton_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(AnulaButton);
            try
            {
                var folio = int.Parse(FolioTextBox.Text);
                CausaAnulacionBHEnum causaAnulacionBh = CausaAnulacionBHEnum.NotSet;
                if (CausaAnulacionErrorDigitacionRadioButton.Checked)
                    causaAnulacionBh = CausaAnulacionBHEnum.ErrorDigitacion;
                else if (CausaAnulacionServicioNoEfectuadoRadioButton.Checked)
                    causaAnulacionBh = CausaAnulacionBHEnum.ServicioNoEfectuado;
                else if (CausaAnulacionServicioNoPagadoRadioButton.Checked)
                    causaAnulacionBh = CausaAnulacionBHEnum.ServicioNoPagado;
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Password;
                var apikey = handler.Configuracion.APIKey;
                var input = new BasicData()
                {
                    RutCertificado =  rutUsuario,
                    Password = password,
                    CertificadoB64 = certificado,
                };
                var (anulacionExitosa, message) = await BHHelper.AnularAsync(input, folio, causaAnulacionBh, apikey);
                if (anulacionExitosa)
                {
                    var buttons = MessageBoxButtons.OK;
                    var messageBoxMessage = "Se anuló exitosamente la boleta de honorarios";
                    var caption = "Resultado Anulación de Boletas de Honorarios";
                    MessageBox.Show(messageBoxMessage, caption, buttons, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Loading.HideLoading(AnulaButton);
        }
    }
}