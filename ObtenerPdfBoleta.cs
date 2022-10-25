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
            RutEmisorTextbox.Text = handler.Configuracion.Empresa.RutEmpresa;
        }

        private async void DescargarPdfButton_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(DescargarPdfButton);
            try
            {
                var rutEmisor = RutEmisorTextbox.Text;
                string tipo = "";
                if (RecibidaRadioButton.Checked)
                    tipo = "recibidas";
                else if (EmitidaRadioButton.Checked)
                    tipo = "emitidas";
                var folio = int.Parse(FolioTextbox.Text);
                var rutUsuario = handler.Configuracion.UsuarioSII.RutUsuario;
                var password = handler.Configuracion.UsuarioSII.PasswordSII;
                var anio = int.Parse(AnioTextbox.Text);
                var apikey = handler.Configuracion.APIKey;
                var input = new BHData
                {
                    RutUsuario =  rutUsuario,
                    PasswordSII = password,
                    RutEmisor = rutEmisor,
                };
                var pdfBytes = await BHHelper.ObtenerPdfBoletaAsync(input, tipo, folio, apikey, anio);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF|*.pdf";
                saveFileDialog.FileName = $"BOLETA_HONORARIOS_{folio}";
                saveFileDialog.ShowDialog();
                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                    MessageBox.Show("PDF descargado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Loading.HideLoading(DescargarPdfButton);
        }
    }
}