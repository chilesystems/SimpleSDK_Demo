using System;
using System.IO;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.Folios;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class DescargarCaf : Form
    {
        Helper handler = new Helper();
        public DescargarCaf()
        {
            InitializeComponent();
        }

        private void DescargarCaf_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextBox.Text = handler.Configuracion.Empresa.RutEmpresa;
            RutEmisorTextBox.Enabled = false;
        }

        private async void DescargarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rutEmisor = RutEmisorTextBox.Text;
                var tipoDte = int.Parse(TipoDteTextBox.Text);
                var cantidad = int.Parse(CantidadTextBox.Text);
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Rut;
                var apikey = handler.Configuracion.APIKey;
                var input = new FoliosData
                {
                    RutUsuario = rutUsuario,
                    Password = password,
                    RutEmpresa = rutEmisor,
                    Ambiente = 0,
                    CertificadoB64 = certificado,
                    Tipo = tipoDte,
                };
                var (hasResponse, message, file) = await FoliosHelper.ObtenerFolios(cantidad, input, apikey);
                if (hasResponse)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.ShowDialog();
                    if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, file);
                    }
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