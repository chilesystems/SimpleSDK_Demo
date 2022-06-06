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
using System.IO;

namespace SimpleSDK_Demo
{
    public partial class GenerarNotaCredito : Form
    {
        Helper handler = new Helper();
        List<ItemBoleta> itemsMontos = new List<ItemBoleta>();
        List<ItemBoleta> itemsTemporal = new List<ItemBoleta>();

        SimpleSDK.Models.DTE.DTE dteOrigen = new SimpleSDK.Models.DTE.DTE();
        public GenerarNotaCredito()
        {
            InitializeComponent();
        }

        private void GenerarDocumentoElectronico_Load(object sender, EventArgs e)
        {
            gridResultados.AutoGenerateColumns = false;

            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();

            textRUTEmisor.Text = handler.Configuracion.Empresa.RutEmpresa;
            textRazonSocialEmisor.Text = handler.Configuracion.Empresa.RazonSocial;
            textDireccionEmisor.Text = handler.Configuracion.Empresa.Direccion;
            textComunaEmisor.Text = handler.Configuracion.Empresa.Comuna;
            textGiroEmisor.Text = handler.Configuracion.Empresa.Giro;

            textRutaCertificado.Text = handler.Configuracion.Certificado.Ruta;
            textRUTCertificado.Text = handler.Configuracion.Certificado.Rut;
            textPassword.Text = handler.Configuracion.Certificado.Password;

            Clone();
            RefreshGrid();

        }

        private List<ItemBoleta> Clone()
        {
            itemsTemporal = new List<ItemBoleta>();
            foreach (var item in itemsMontos)
                itemsTemporal.Add(new ItemBoleta()
                {
                    Afecto = item.Afecto,
                    Cantidad = item.Cantidad,
                    Descuento = item.Descuento,
                    Nombre = item.Nombre,
                    Precio = item.Precio,
                    TipoImpuesto = item.TipoImpuesto,
                    UnidadMedida = item.UnidadMedida
                });
            return itemsTemporal;
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

            var emisor = new SimpleSDK.Models.DTE.Emisor()
            {
                Rut = textRUTEmisor.Text,
                RazonSocial = textRazonSocialEmisor.Text,
                DireccionOrigen = textDireccionEmisor.Text,
                ComunaOrigen = textComunaEmisor.Text,
                Giro = textGiroEmisor.Text,
                ActividadEconomica = handler.Configuracion.Empresa.CodigosActividades.Select(x => x.Codigo).ToList()
            };

            var receptor = new SimpleSDK.Models.DTE.Receptor()
            {
                Rut = textRUTReceptor.Text,
                RazonSocial = textRazonSocialReceptor.Text,
                Direccion = textDireccionReceptor.Text,
                Comuna = textComunaReceptor.Text,
                Ciudad = textComunaReceptor.Text,
                Giro = textGiroReceptor.Text
            };

            //Creación del objeto
            var dte = new SimpleSDK.Models.DTE.DTE(emisor, receptor, (int)numericFolio.Value, TipoDTE.DTEType.NotaCreditoElectronica);

            //Asignación de detalles
            dte.Documento.Detalles = handler.ItemboletaADetalle(itemsMontos);

            dte.CalcularTotales();
            
            //Todas las NC y ND, deben llevar una referencia a su documento de origen

            var tipoOperacion = TipoReferencia.TipoReferenciaEnum.NotSet;
            string razonReferencia = "";
            if (radioAnula.Checked)
            {
                tipoOperacion = TipoReferencia.TipoReferenciaEnum.AnulaDocumentoReferencia;
                razonReferencia = "ANULA DOCUMENTO DE REFERENCIA";
            }
            else if (radioModificaMontos.Checked)
            {
                tipoOperacion = TipoReferencia.TipoReferenciaEnum.CorrigeMontos;
                razonReferencia = "MODIFICA MONTOS DE DOCUMENTO DE REFERENCIA";
            }
            else if (radioModificaTextos.Checked)
            {
                tipoOperacion = TipoReferencia.TipoReferenciaEnum.CorrigeTextoDocumentoReferencia;
                razonReferencia = "MODIFICA TEXTO DE DOCUMENTO DE REFERENCIA";
            }

            var tipoDteOrigen = TipoDTE.TipoReferencia.NotSet;
            if (dteOrigen.Documento.Encabezado.IdentificacionDTE.TipoDTE == TipoDTE.DTEType.FacturaElectronica)
                tipoDteOrigen = TipoDTE.TipoReferencia.FacturaElectronica;
            else if (dteOrigen.Documento.Encabezado.IdentificacionDTE.TipoDTE == TipoDTE.DTEType.BoletaElectronica)
                tipoDteOrigen = TipoDTE.TipoReferencia.BoletaElectronica;

            //Si se trata de un caso del set de pruebas para certificación
            if (checkSetPruebas.Checked)
            {
                string casoPrueba = "CASO-" + numericCasoPrueba.Value.ToString("N0");
                var referenciaPrueba = handler.ReferenciaSetdePruebas(tipoDteOrigen, null, 0, casoPrueba);
                dte.Documento.Referencias.Add(referenciaPrueba);
            }

            dte.Documento.Referencias.Add(new SimpleSDK.Models.DTE.Referencia() 
            {
                CodigoReferencia = tipoOperacion,
                FechaDocumentoReferencia = DateTime.Now,
                FolioReferencia = dteOrigen.Documento.Encabezado.IdentificacionDTE.Folio.ToString(),
                Numero = dte.Documento.Referencias.Count + 1,
                TipoDocumento = tipoDteOrigen,
                RazonReferencia = razonReferencia
            });


            dte.Certificado.Ruta = textRutaCertificado.Text;
            dte.Certificado.Rut = textRUTCertificado.Text;
            dte.Certificado.Password = textPassword.Text;


            //Obtenemos nuestro XML
            var result = await dte.GenerarXMLAsync(textPathCAF.Text, handler.Configuracion.APIKey);
            if (result.Item1)
            {
                var pathDTE = System.IO.Path.Combine(AppContext.BaseDirectory, $"DTE_61_{emisor.Rut}_{numericFolio.Value}.xml");
                System.IO.File.WriteAllText(pathDTE, result.Item2, Encoding.GetEncoding("ISO-8859-1"));
                MessageBox.Show($"Documento generado exitosamente y guardado en {pathDTE}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 6)
            {
                if (radioAnula.Checked)
                {
                    MessageBox.Show("No se pueden quitar productos cuando se anula un documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (radioModificaTextos.Checked)
                {
                    MessageBox.Show("No se pueden quitar productos cuando se modifica texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (radioModificaMontos.Checked)
                {
                    var item = gridResultados.Rows[e.RowIndex].DataBoundItem as ItemBoleta;
                    itemsTemporal.Remove(item);
                    gridResultados.DataSource = null;
                    gridResultados.DataSource = itemsTemporal;
                    calculoTotales();
                }
            }
        }
        private void calculoTotales()
        {
            var total = itemsTemporal.Sum(x => x.Total);
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

        private void botonCargarDTE_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos DTE (*.xml)|*.xml";
                var result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textDTEPath.Text = openFileDialog.FileName;
                    string xml = File.ReadAllText(textDTEPath.Text, Encoding.GetEncoding("ISO-8859-1"));
                    dteOrigen = XMLHelper.DeserializeFromString<SimpleSDK.Models.DTE.DTE>(xml);

                    textRUTReceptor.Text = dteOrigen.Documento.Encabezado.Receptor.Rut;
                    textRazonSocialReceptor.Text = dteOrigen.Documento.Encabezado.Receptor.RazonSocial;
                    textDireccionReceptor.Text = dteOrigen.Documento.Encabezado.Receptor.Direccion;
                    textComunaReceptor.Text = dteOrigen.Documento.Encabezado.Receptor.Comuna;
                    textGiroReceptor.Text = dteOrigen.Documento.Encabezado.Receptor.Giro;
                  
                    gridResultados.DataSource = itemsMontos = handler.DetalleAItemBoleta(dteOrigen.Documento.Detalles);
                    Clone();
                    RefreshGrid();
                }
            }
        }

        private void radioAnula_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAnula.Checked)
            {
                gridResultados.ReadOnly = true;
                Clone();
                RefreshGrid();
            }
        }

        private void radioModificaMontos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModificaMontos.Checked)
            {
                gridResultados.ReadOnly = false;
                Clone();
                RefreshGrid();
            }            
        }

        private void radioModificaTextos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModificaTextos.Checked)
            {
                gridResultados.ReadOnly = true;
                var temp = new ItemBoleta()
                {
                    Nombre = "DONDE DICE X, DEBE DECIR Y",
                    Cantidad = 0,
                    Precio = 0
                };
                itemsTemporal.Clear();
                itemsTemporal.Add(temp);
                RefreshGrid();
            }            
        }

        private void RefreshGrid()
        {
            gridResultados.DataSource = null;
            gridResultados.DataSource = itemsTemporal;
            calculoTotales();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void checkSetPruebas_CheckedChanged(object sender, EventArgs e)
        {
            labelCasoPrueba.Enabled = numericCasoPrueba.Enabled = checkSetPruebas.Checked;
        }
    }
}
