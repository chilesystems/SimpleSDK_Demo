using BHE.Models;
using SimpleSDK.Helpers;
using SimpleSDK_Demo.Models;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using SimpleSDK.Models.BHE;
using System.Windows.Forms;

namespace SimpleSDK_Demo
{
    public partial class ListadoComunas : Form
    {
        Helper handler = new Helper();
        public ListadoComunas()
        {
            InitializeComponent();
            this.Load += ListadoComunas_Load;
        }

        private void gridResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ListadoButton_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(gridResultados);
            if (string.IsNullOrWhiteSpace(handler.Configuracion.APIKey))
            {
                MessageBox.Show("API Key no configurada. Por favor, verifica tu configuración.", "Configuración Faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Deshabilitar el botón y mostrar cursor de espera
            ListadoButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Llamar al método para obtener la lista de Regiones y Comunas
                var regionesData = await BHHelper.ObtenerListaComunasAsync(handler.Configuracion.APIKey);

                // Limpiar datos existentes en el grid
                gridResultados.Rows.Clear();

                // Iterar sobre las Regiones y Comunas para poblar el grid
                foreach (var region in regionesData.Regiones)
                {
                    foreach (var comuna in region.Comunas)
                    {
                        gridResultados.Rows.Add(region.Nombre, comuna);
                    }
                }

                
                gridResultados.DataSource = regionesData.Regiones.SelectMany(r => r.Comunas.Select(c => new { Region = r.Nombre, Comuna = c })).ToList();

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Archivo No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error en la solicitud HTTP: {ex.Message}", "Error de Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show($"Error de aplicación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Loading.HideLoading(gridResultados);
                ListadoButton.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void ListadoComunas_Load(object sender, EventArgs e)
        {
            try
            {
                handler.Configuracion = new Configuracion();
                handler.Configuracion.LeerArchivo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la configuración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }
    
    }
}
