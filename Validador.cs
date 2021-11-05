using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSDK_Demo
{
    public partial class Validador : Form
    {
        Helper handler = new Helper();
        public Validador()
        {
            InitializeComponent();
        }

        private void Validador_Load(object sender, EventArgs e)
        {
            comboTipo.SelectedIndex = 0;
            handler.Configuracion = new Models.Configuracion();
            handler.Configuracion.LeerArchivo();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && File.Exists(openFileDialog.FileName))
            {
                txtFilePath.Text = openFileDialog.FileName;
                textDocumento.Text = openFileDialog.SafeFileName;
            }
        }

        private async void botonValidar_Click(object sender, EventArgs e)
        {
            try
            {
                //string xml = File.ReadAllText(textDocumento.Text, Encoding.GetEncoding("ISO-8859-1"));

                var validador = new SimpleSDK.Models.Extras.Validador();
                validador.FilePath = txtFilePath.Text;
                switch (comboTipo.SelectedIndex)
                {
                    case 0: validador.Tipo = SimpleSDK.Enum.TipoEnvio.ValidacionType.DTE;
                        break;
                    case 1: validador.Tipo = SimpleSDK.Enum.TipoEnvio.ValidacionType.EnvioDTE;
                        break;
                    case 2: validador.Tipo = SimpleSDK.Enum.TipoEnvio.ValidacionType.EnvioBoleta;
                        break;
                    case 3: validador.Tipo = SimpleSDK.Enum.TipoEnvio.ValidacionType.LibroGuias;
                        break;
                    case 4: validador.Tipo = SimpleSDK.Enum.TipoEnvio.ValidacionType.RVD;
                        break;
                    case 5: validador.Tipo = SimpleSDK.Enum.TipoEnvio.ValidacionType.LCV;
                        break;
                }

                var result = await validador.ConsultarAlSII(handler.Configuracion.APIKey);
                textResultado.Text = result;
            }
            catch (Exception ex)
            {
                textResultado.Text = "ERROR: " + ex.ToString();
            }

        }
    }
}
