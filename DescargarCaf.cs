using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.Folios;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class DescargarCaf : Form
    {
        Helper handler = new Helper();
        public DescargarCaf(bool certificacion = false)
        {
            InitializeComponent();
            radioCertificacion.Checked = certificacion;
            radioProduccion.Checked = !certificacion;
        }

        private void DescargarCaf_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextBox.Text = handler.Configuracion.Empresa.RutEmpresa;

            var tipos = ((SimpleSDK.Enum.TipoDTE.DTEFoliosType[])Enum.GetValues(typeof(SimpleSDK.Enum.TipoDTE.DTEFoliosType))).OrderBy(x => x.ToString());
            foreach (var tipo in tipos) comboTipo.Items.Add(tipo);

            comboTipo.SelectedItem = SimpleSDK.Enum.TipoDTE.DTEFoliosType.NotSet;
        }

        private async void ConsultarButton_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(DescargarButton);
            try
            {
                var rutEmisor = RutEmisorTextBox.Text;
                Enum.TryParse(comboTipo.SelectedItem.ToString(), out SimpleSDK.Enum.TipoDTE.DTEFoliosType tipoDTE);


                int ambiente = 1;
                if (radioCertificacion.Checked)
                    ambiente = 0;

                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Password;
                var apikey = handler.Configuracion.APIKey;
                var input = new FoliosData
                {
                    RutCertificado = rutUsuario,
                    Password = password,
                    RutEmpresa = rutEmisor,
                    Ambiente = ambiente,
                    CertificadoB64 = certificado,
                    Tipo = (int)tipoDTE
                };

                var (hasResponse, message, file) = await FoliosHelper.ObtenerFolios((int)numericCantidad.Value, input, apikey, new WinHttpHandler());
                if (hasResponse)
                {
                    MessageBox.Show("Folios descargados con éxito. Por favor indique donde guardará el archivo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.ShowDialog();
                    if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, file);
                    }
                    MessageBox.Show("Folios guardados con éxito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"Ocurrió un error: {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + Environment.NewLine + exception.InnerException?.Message ?? "");
            }
            Loading.HideLoading(DescargarButton);
        }
    }
}