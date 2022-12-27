using SimpleSDK.Enum;
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
using SimpleSDK.Helpers;

namespace SimpleSDK_Demo
{
    public partial class GenerarDocumentoElectronicoExportacion : Form
    {
        Helper handler = new Helper();
        List<ItemBoleta> items = new List<ItemBoleta>();

        public GenerarDocumentoElectronicoExportacion()
        {
            InitializeComponent();
        }

        private void GenerarDocumentoElectronico_Load(object sender, EventArgs e)
        {
            gridResultados.AutoGenerateColumns = false;
            comboTipo.SelectedIndex = 0;

            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();

            textRUTEmisor.Text = handler.Configuracion.Empresa.RutEmpresa;
            textRazonSocialEmisor.Text = handler.Configuracion.Empresa.RazonSocial;
            textDireccionEmisor.Text = handler.Configuracion.Empresa.Direccion;
            textComunaEmisor.Text = handler.Configuracion.Empresa.Comuna;
            textGiroEmisor.Text = handler.Configuracion.Empresa.Giro;

            textRUTReceptor.Text = "66666666-6";
            textRazonSocialReceptor.Text = "Razón Social de Cliente";
            textDireccionReceptor.Text = "Dirección de Cliente";
            textComunaReceptor.Text = "Comuna de Cliente";
            textGiroReceptor.Text = "Giro de Cliente";

            textRutaCertificado.Text = handler.Configuracion.Certificado.Ruta;
            textRUTCertificado.Text = handler.Configuracion.Certificado.Rut;
            textPassword.Text = handler.Configuracion.Certificado.Password;
        }

        private async void botonGenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textRutaCertificado.Text))
            {
                MessageBox.Show("Se requiere un certificado digital.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.IO.File.Exists(textRutaCertificado.Text))
            {
                MessageBox.Show("Ruta incorrecta. No fue posible encontrar un certificado digital en esta ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textPathCAF.Text))
            {
                MessageBox.Show("Se requiere un archivo CAF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.IO.File.Exists(textPathCAF.Text))
            {
                MessageBox.Show("Ruta incorrecta. No fue posible encontrar un archivo CAF en esta ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tipoDte = comboTipo.SelectedIndex == 0 ? TipoDTE.DTEType.BoletaElectronica : TipoDTE.DTEType.FacturaElectronica;

            var emisor = new SimpleSDK.Models.DTE.Emisor()
            {
                Rut = textRUTEmisor.Text,
                DireccionOrigen = textDireccionEmisor.Text,
                ComunaOrigen = textComunaEmisor.Text
            };

            var receptor = new SimpleSDK.Models.DTE.Receptor()
            {
                Rut = textRUTReceptor.Text,
                RazonSocial = textRazonSocialReceptor.Text,
                Direccion = textDireccionReceptor.Text,
                Comuna = textComunaReceptor.Text
            };

            //Etiquetas propias para boletas y para el resto.
            if (tipoDte == TipoDTE.DTEType.BoletaElectronica || tipoDte == TipoDTE.DTEType.BoletaElectronicaExenta)
            {
                emisor.RazonSocialBoleta = textRazonSocialEmisor.Text;
                emisor.GiroBoleta = textGiroEmisor.Text;
            }
            else
            {
                emisor.RazonSocial = textRazonSocialEmisor.Text;
                emisor.Giro = textGiroEmisor.Text;
                emisor.ActividadEconomica = handler.Configuracion.Empresa.CodigosActividades.Select(x => x.Codigo).ToList();
                receptor.Ciudad = receptor.Comuna;
                receptor.Giro = textGiroReceptor.Text;
            }

            //Creación del objeto
            var dte = new SimpleSDK.Models.DTE.DTE(emisor, receptor, (int)numericFolio.Value, tipoDte);

            //Asignación de detalles
            dte.Documento.Detalles = handler.ItemboletaADetalle(items);

            dte.CalcularTotales();

            //Si se trata de un caso del set de pruebas para certificación
            if (checkSetPruebas.Checked)
            {
                //Para facturas electrónicas debes agregar aquí el n° de atención CASO {N°Atencion}-{NumeroCaso}

                string casoPrueba = "CASO 123456-" + numericCasoPrueba.Value.ToString("N0");
                //Para boletas electrónicas no se requiere agregar el número de atención. 
                //string casoPrueba = "CASO-" + numericCasoPrueba.Value.ToString("N0");
                var referenciaPrueba = handler.ReferenciaSetdePruebas(tipoDte == TipoDTE.DTEType.BoletaElectronica ? "39" : "33", null, 0, casoPrueba);
                dte.Documento.Referencias.Add(referenciaPrueba);
            }

            dte.Certificado.Ruta = textRutaCertificado.Text;
            dte.Certificado.Rut = textRUTCertificado.Text;
            dte.Certificado.Password = textPassword.Text;

            try 
            {
                var result = await dte.GenerarXMLAsync(textPathCAF.Text, handler.Configuracion.APIKey);
                if (result.Item1)
                {
                    var pathDTE = System.IO.Path.Combine(AppContext.BaseDirectory, $"DTE_{(int)tipoDte}_{emisor.Rut}_{numericFolio.Value}.xml");
                    System.IO.File.WriteAllText(pathDTE, result.Item2, Encoding.GetEncoding("ISO-8859-1"));
                    MessageBox.Show($"Documento generado exitosamente y guardado en {pathDTE}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //Obtenemos nuestro XML
            

        }

        private void gridResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    var item = gridResultados.Rows[e.RowIndex].DataBoundItem as ItemBoleta;
                    items.Remove(item);
                    gridResultados.DataSource = null;
                    gridResultados.DataSource = items;
                    calculoTotales();
                }
            }
        }

        private void botonAgregarLinea_Click(object sender, EventArgs e)
        {
            ItemBoleta item = new ItemBoleta();
            item.Nombre = textNombre.Text;
            item.Cantidad = (double)numericCantidad.Value;
            item.Afecto = checkAfecto.Checked;
            item.Precio = (int)numericPrecio.Value;
            item.UnidadMedida = checkUnidad.Checked ? "Kg." : string.Empty;
            items.Add(item);
            gridResultados.DataSource = null;
            gridResultados.DataSource = items;

            textNombre.Text = "";
            numericCantidad.Value = 1;
            checkAfecto.Checked = true;

            calculoTotales();
        }

        private void calculoTotales()
        {
            var total = items.Sum(x => x.Total);
            var neto = Math.Round(total / 1.19, 0);

            textNeto.Text = neto.ToString("N0");
            textIVA.Text = (total - neto).ToString("N0");
            textTotal.Text = total.ToString("N0");
        }

        private void botonBuscarCAF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivo CAF (*.xml)|*.xml";
                var result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textPathCAF.Text = openFileDialog.FileName;
                }
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

        private void checkSetPruebas_CheckedChanged(object sender, EventArgs e)
        {
            labelCasoPrueba.Enabled = numericCasoPrueba.Enabled = checkSetPruebas.Checked;
        }
    }
}
