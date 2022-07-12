using System;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using SimpleSDK.Helpers;
using SimpleSDK.Models.Folios;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class ConsultarCAFs : Form
    {
        Helper handler = new Helper();
        public ConsultarCAFs(bool certificacion = false)
        {
            InitializeComponent();
            radioCertificacion.Checked = certificacion;
            radioProduccion.Checked = !certificacion;
        }
        private void ConsultarUltimosCincoCafs_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextBox.Text = handler.Configuracion.Empresa.RutEmpresa;
            RutEmisorTextBox.Enabled = false;

            var tipos = ((SimpleSDK.Enum.TipoDTE.DTEFoliosType[])Enum.GetValues(typeof(SimpleSDK.Enum.TipoDTE.DTEFoliosType))).OrderBy(x => x.ToString());
            foreach (var tipo in tipos) comboTipo.Items.Add(tipo);

            comboTipo.SelectedItem = SimpleSDK.Enum.TipoDTE.DTEFoliosType.NotSet;
        }

        private async void ConsultarButton_Click(object sender, EventArgs e)
        {
            Enum.TryParse(comboTipo.SelectedItem.ToString(), out SimpleSDK.Enum.TipoDTE.DTEFoliosType tipoDTE);
            if (tipoDTE == SimpleSDK.Enum.TipoDTE.DTEFoliosType.NotSet)
            {
                MessageBox.Show("Debe seleccionar un tipo de DTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Loading.ShowLoading(dataGrid1);
            ConsultarButton.Enabled = false;
            try
            {
               
                var rutEmisor = RutEmisorTextBox.Text;
                var desde = DesdeDateTimePicker.Value;
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
                    Tipo = (int)tipoDTE,
                };
                var (hasResponse, message, infoFolios) = await FoliosHelper.ResumenFolios(desde, input, apikey);
                if (hasResponse)
                {
                    dataGrid1.AutoSize = true;
                    dataGrid1.DataSource = infoFolios.Detalles;
                    Console.WriteLine(JsonConvert.SerializeObject(infoFolios));
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(message);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(exception);
            }
            Loading.HideLoading(dataGrid1);
            ConsultarButton.Enabled = true;
        }

    }
}