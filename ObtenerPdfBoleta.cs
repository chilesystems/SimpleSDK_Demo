using System;
using System.IO;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.BHE;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class ObtenerPdfBoleta : Form
    {
        Helper handler = new Helper();
        public ObtenerPdfBoleta()
        {
            InitializeComponent();
        }

        private void ObtenerPdfBoleta_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextbox.Text = handler.Configuracion.Certificado.Rut;
            RutEmisorTextbox.Enabled = false;
        }


        private async void DescargarPdfButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rutEmisor = RutEmisorTextbox.Text;
                string tipo = "";
                if (RecibidaRadioButton.Checked)
                    tipo = "recibidas";
                else if (EmitidaRadioButton.Checked)
                    tipo = "emitidas";
                var folio = int.Parse(FolioTextbox.Text);
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Rut;
                var anio = int.Parse(AnioTextbox.Text);
                var apikey = handler.Configuracion.APIKey;
                var input = new BHData
                {
                    RutUsuario = rutUsuario,
                    Password = password,
                    CertificadoB64 = certificado,
                    RutEmisor = rutEmisor,
                };
                var pdfBytes = await BHHelper.ObtenerPdfBoletaAsync(input, tipo, folio, apikey, anio);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.ShowDialog();
                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}