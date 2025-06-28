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
    public partial class GenerarDocumentoElectronico : Form
    {
        readonly Helper handler = new Helper();
        readonly List<ItemBoleta> items = new List<ItemBoleta>();

        public GenerarDocumentoElectronico()
        {
            InitializeComponent();
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);

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

            groupBoxTransporte.Enabled = false;
            groupBoxTransporte.Visible = true;

        }

        private async void BotonGenerar_Click(object sender, EventArgs e)
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
            else if (items.Count == 0)
            {
                MessageBox.Show("Se requiere al menos un detalle ingresado en la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (tipoDte == TipoDTE.DTEType.GuiaDespachoElectronica)
            {
                var transporte = new SimpleSDK.Models.DTE.Transporte()
                {
                    Patente = textBoxPatente.Text,
                    RutTransportista = textBoxRutTranspote.Text,
                    Chofer = new SimpleSDK.Models.DTE.Chofer()
                    {
                        Rut = textBoxRutChofer.Text,
                        Nombre = textBoxNombreChofer.Text
                    }
                };

                dte.Documento.Encabezado.Transporte = transporte;
            }

            //Si se quiere agregar un descuento en porcentaje o pesos. Se aplica sobre el neto.
            //No se calculan los descuentos globales si es boleta. Se debe aplicar antes de traspasar los valores al DTE (Neto, IVA y Total).
            //dte.Documento.DescuentosRecargos.Add(new SimpleSDK.Models.DTE.DescuentosRecargos()
            //{
            //    Descripcion = "Descuento prueba",
            //    TipoMovimiento = TipoMovimiento.TipoMovimientoEnum.Descuento,
            //    Valor = 3201,
            //    TipoValor = ExpresionDinero.ExpresionDineroEnum.Pesos,
            //    Numero = 1
            //});

            dte.CalcularTotales();

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

        private void GridResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    var item = gridResultados.Rows[e.RowIndex].DataBoundItem as ItemBoleta;
                    items.Remove(item);
                    gridResultados.DataSource = null;
                    gridResultados.DataSource = items;
                    CalculoTotales();
                }
            }
        }

        private void BotonAgregarLinea_Click(object sender, EventArgs e)
        {
            ItemBoleta item = new ItemBoleta
            {
                Nombre = textNombre.Text,
                Cantidad = (double)numericCantidad.Value,
                Afecto = checkAfecto.Checked,
                Precio = (int)numericPrecio.Value,
                UnidadMedida = checkUnidad.Checked ? "Kg." : string.Empty,
             
            };
            items.Add(item);
            gridResultados.DataSource = null;
            gridResultados.DataSource = items;

            textNombre.Text = "";
            numericCantidad.Value = 1;
            checkAfecto.Checked = true;

            CalculoTotales();
        }

        private void CalculoTotales()
        {
            var total = items.Sum(x => x.Total);
            var neto = Math.Round(total / 1.19, 0);

            textNeto.Text = neto.ToString("N0");
            textIVA.Text = (total - neto).ToString("N0");
            textTotal.Text = total.ToString("N0");
        }

        private void BotonBuscarCAF_Click(object sender, EventArgs e)
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

        private void BotonBuscarCertificado_Click(object sender, EventArgs e)
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

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asegúrate de comparar el texto y no el índice (en caso de que el orden cambie)
            if (comboTipo.SelectedItem != null && comboTipo.SelectedItem.ToString().ToUpper().Contains("GUÍA DE DESPACHO"))
            {
                groupBoxTransporte.Enabled = true;
            }
            else
            {
                groupBoxTransporte.Enabled = false;
            }
        }

    }
}
