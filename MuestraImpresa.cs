using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSDK_Demo
{
    public partial class MuestraImpresa : Form
    {
        Helper handler = new Helper();
        public MuestraImpresa()
        {
            InitializeComponent();
        }

        private async void botonVisualizar_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione un DTE";
            openFileDialog.Filter = "Archivo DTE (*.xml)|*.xml";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && File.Exists(openFileDialog.FileName))
            {
                var validador = new SimpleSDK.Models.Extras.MuestraImpresa();
                validador.FilePath = openFileDialog.FileName;
                validador.NumeroResolucion = (int)numericNroRes.Value;
                validador.UnidadSII = textUnidadSII.Text;
                validador.FechaResolucion = dateFechaRes.Value.Date;
                validador.Hora = dateHoraEmision.Value.ToShortTimeString();
                validador.Vendedor = textVendedor.Text;
                validador.FormaPago = textFormaPago.Text;
                validador.CondicionVenta = textCondVenta.Text;

                validador.LogoBase64 = !string.IsNullOrEmpty(txtFilePath.Text) ? Convert.ToBase64String(File.ReadAllBytes(txtFilePath.Text)) : "";

                string formato = radio58m.Checked ? "58mm" : "carta";
                string salida = radioPDF.Checked ? "pdf" : "base64";

                var resultMuestra = await validador.ObtenerMuestra(handler.Configuracion.APIKey, formato, salida);
                if (resultMuestra.Item1)
                {
                    if (radioPDF.Checked)
                    {
                        var p = new Process();
                        p.StartInfo = new ProcessStartInfo(resultMuestra.Item2)
                        {
                            UseShellExecute = true
                        };
                        p.Start();
                    }
                    else
                    {
                        ResultadoOperacion formulario = new ResultadoOperacion(resultMuestra.Item2);
                        formulario.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show(resultMuestra.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MuestraImpresa_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Models.Configuracion();
            handler.Configuracion.LeerArchivo();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione un logo";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && File.Exists(openFileDialog.FileName))
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

    }
}
