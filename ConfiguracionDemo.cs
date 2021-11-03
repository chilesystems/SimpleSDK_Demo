using SimpleSDK_Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSDK_Demo
{
    public partial class ConfiguracionDemo : Form
    {
        Configuracion configuracion = new Configuracion();
        public ConfiguracionDemo()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {            
            try
            {
                configuracion.LeerArchivo();

                textRutEmpresa.Text = configuracion.Empresa.RutEmpresa;
                textGiro.Text = configuracion.Empresa.Giro;
                textRazonSocial.Text = configuracion.Empresa.RazonSocial;
                textComuna.Text = configuracion.Empresa.Comuna;
                textDireccionEmpresa.Text = configuracion.Empresa.Direccion;
                textRutCertificado.Text = configuracion.Certificado.Rut;
                textRutaCertificado.Text = configuracion.Certificado.Ruta;
                textPassword.Text = configuracion.Certificado.Password;

                numericNResolucion.Value = configuracion.Empresa.NumeroResolucion;
                dateFechaResolucion.Value = configuracion.Empresa.FechaResolucion;
                textAPIKey.Text = configuracion.APIKey;

                gridResultados.DataSource = null;
                gridResultados.DataSource = configuracion.Empresa.CodigosActividades;
            }
            catch { }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            configuracion.Empresa.RutEmpresa = textRutEmpresa.Text;
            configuracion.Empresa.Giro = textGiro.Text;
            configuracion.Empresa.RazonSocial = textRazonSocial.Text;
            configuracion.Empresa.Comuna = textComuna.Text;
            configuracion.Empresa.Direccion = textDireccionEmpresa.Text;
            configuracion.Empresa.NumeroResolucion = (int)numericNResolucion.Value;
            configuracion.Empresa.FechaResolucion = dateFechaResolucion.Value.Date;
            configuracion.APIKey = textAPIKey.Text;

            configuracion.Certificado.Rut = textRutCertificado.Text;
            configuracion.Certificado.Ruta = textRutaCertificado.Text;
            configuracion.Certificado.Password = textPassword.Text;

            configuracion.GenerarArchivo();

            MessageBox.Show("Configuración guardada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void botonGuardarActividad_Click(object sender, EventArgs e)
        {

            if (configuracion.Empresa.CodigosActividades.Count > 3)
            {
                MessageBox.Show("Sólo se permite un máximo de 4 actividades económicas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            configuracion.Empresa.CodigosActividades.Add(new ActividadEconomica() { Codigo = int.Parse(textNumeroActividad.Text) });

            gridResultados.DataSource = null;
            gridResultados.DataSource = configuracion.Empresa.CodigosActividades;
            textNumeroActividad.Text = "";
        }

        private void gridResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 1)
            {
                var Codigo = gridResultados.Rows[e.RowIndex].DataBoundItem as ActividadEconomica;
                configuracion.Empresa.CodigosActividades.Remove(Codigo);
                gridResultados.DataSource = null;
                gridResultados.DataSource = configuracion.Empresa.CodigosActividades;
            }
        }

        private void botonBuscarCertificado_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Certificado Digital (*.pfx)|*.pfx";
                var result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textRutaCertificado.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
