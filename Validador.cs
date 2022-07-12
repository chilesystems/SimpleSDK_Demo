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
            openFileDialog.Title = "Seleccione un archivo a validar";
            openFileDialog.Filter = "Archivo XML (*.xml)|*.xml";
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
                var validador = new SimpleSDK.Models.Extras.Validador();
                validador.FilePath = txtFilePath.Text;
                validador.Tipo = (SimpleSDK.Enum.TipoEnvio.ValidacionType)comboTipo.SelectedIndex + 1;
                var result = await validador.ConsultarAlSII(handler.Configuracion.APIKey);
                textResultado.Text = result;
            }
            catch (Exception ex)
            {
                textResultado.Text = "ERROR: " + ex.ToString();
            }

        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
