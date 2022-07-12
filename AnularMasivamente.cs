using System;
using System.Linq;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.Folios;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class AnularMasivamente : Form
    {
        Helper handler = new Helper();
        public AnularMasivamente(bool certificacion = false)
        {
            InitializeComponent();
            radioCertificacion.Checked = certificacion;
            radioProduccion.Checked = !certificacion;
        }

        private void AnularMasivamente_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextBox.Text = handler.Configuracion.Empresa.RutEmpresa;
            RutEmisorTextBox.Enabled = false;

            var tipos = ((SimpleSDK.Enum.TipoDTE.DTEFoliosType[])Enum.GetValues(typeof(SimpleSDK.Enum.TipoDTE.DTEFoliosType))).OrderBy(x => x.ToString());
            foreach (var tipo in tipos) comboTipo.Items.Add(tipo);

            comboTipo.SelectedItem = SimpleSDK.Enum.TipoDTE.DTEFoliosType.NotSet;
        }

        private async void AnularButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMotivoAnulacion.Text))
            {
                MessageBox.Show("El motivo no puede ir vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Enum.TryParse(comboTipo.SelectedItem.ToString(), out SimpleSDK.Enum.TipoDTE.DTEFoliosType tipoDTE);
            if (tipoDTE == SimpleSDK.Enum.TipoDTE.DTEFoliosType.NotSet)
            {
                MessageBox.Show("Debe seleccionar un tipo de DTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Loading.ShowLoading(AnularButton);
            try
            {
               
                var rutEmisor = RutEmisorTextBox.Text;
                var desde = (int)numericDesde.Value;
                var hasta = (int)numericHasta.Value;
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Password;
                var apikey = handler.Configuracion.APIKey;
                var input = new FoliosData
                {
                    RutCertificado =  rutUsuario,
                    Password = password,
                    RutEmpresa = rutEmisor,
                    Ambiente = radioCertificacion.Checked ? 0 : 1,
                    CertificadoB64 = certificado,
                    MotivoAnulacion = textMotivoAnulacion.Text,
                    Tipo = (int)tipoDTE,
                };
                var (anulacionExitosa, message) = await FoliosHelper.AnulacionMasiva(desde, hasta, input, apikey);
                var icon = anulacionExitosa ? MessageBoxIcon.Information : MessageBoxIcon.Error;
                var caption = "Resultado Anulación de Folios";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            Loading.HideLoading(AnularButton);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}