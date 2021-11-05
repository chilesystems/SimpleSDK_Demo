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
    public partial class MuestraTimbre : Form
    {
        Helper handler = new Helper();
        public MuestraTimbre()
        {
            InitializeComponent();
        }
        private void MuestraTimbre_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Models.Configuracion();
            handler.Configuracion.LeerArchivo();
        }
        private async void botonCargarDTE_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione un DTE";
            openFileDialog.Filter = "Archivo DTE (*.xml)|*.xml";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && File.Exists(openFileDialog.FileName))
            {
                var validador = new SimpleSDK.Models.Extras.MuestraImpresa();
                validador.FilePath = openFileDialog.FileName;

                var timbre64 = await validador.ObtenerTimbre(handler.Configuracion.APIKey);
                var pic = Convert.FromBase64String(timbre64);
                using (MemoryStream ms = new MemoryStream(pic))
                {
                    pictureBoxTimbre.BackgroundImage = Image.FromStream(ms);
                }
            }
        }

    }
}
