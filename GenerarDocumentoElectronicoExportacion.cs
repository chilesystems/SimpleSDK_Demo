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

            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();

            textRUTEmisor.Text = handler.Configuracion.Empresa.RutEmpresa;
            textRazonSocialEmisor.Text = handler.Configuracion.Empresa.RazonSocial;
            textDireccionEmisor.Text = handler.Configuracion.Empresa.Direccion;
            textComunaEmisor.Text = handler.Configuracion.Empresa.Comuna;
            textGiroEmisor.Text = handler.Configuracion.Empresa.Giro;

            textRazonSocialReceptor.Text = "Razón Social de Cliente";
            textDireccionReceptor.Text = "Dirección de Cliente";
            textCiudadReceptor.Text = "Ciudad de Cliente";
            textGiroReceptor.Text = "Giro de Cliente";
            textRUTReceptor.Text = "55555555-5";

            textRutaCertificado.Text = handler.Configuracion.Certificado.Ruta;
            textRUTCertificado.Text = handler.Configuracion.Certificado.Rut;
            textPassword.Text = handler.Configuracion.Certificado.Password;

            var transportes = ((SimpleSDK.Enum.CodigosAduana.ViasdeTransporte[])Enum.GetValues(typeof(SimpleSDK.Enum.CodigosAduana.ViasdeTransporte))).OrderBy(x => x.ToString());
            foreach (var transporte in transportes) comboViaTransporte.Items.Add(transporte);

            comboViaTransporte.SelectedItem = SimpleSDK.Enum.CodigosAduana.ViasdeTransporte.MARITINA_FLUVIAL_Y_LACUSTRE;

            var paisesDestino = ((SimpleSDK.Enum.CodigosAduana.Paises[])Enum.GetValues(typeof(SimpleSDK.Enum.CodigosAduana.Paises))).OrderBy(x => x.ToString());
            foreach (var paisDestino in paisesDestino) comboPaisReceptorDestino.Items.Add(paisDestino);

            comboPaisReceptorDestino.SelectedItem = SimpleSDK.Enum.CodigosAduana.Paises.AFGHANISTAN;

            var puertosEmbarque = ((SimpleSDK.Enum.CodigosAduana.Puertos[])Enum.GetValues(typeof(SimpleSDK.Enum.CodigosAduana.Puertos))).OrderBy(x => x.ToString());
            foreach (var puertoEmbarque in puertosEmbarque) comboPuertoEmbarque.Items.Add(puertoEmbarque);

            comboPuertoEmbarque.SelectedItem = SimpleSDK.Enum.CodigosAduana.Puertos.ABRA_DE_NAPA;

            var puertosDesembarque = ((SimpleSDK.Enum.CodigosAduana.Puertos[])Enum.GetValues(typeof(SimpleSDK.Enum.CodigosAduana.Puertos))).OrderBy(x => x.ToString());
            foreach (var puertoDesembarque in puertosDesembarque) comboPuertoDesembarque.Items.Add(puertoDesembarque);

            comboPuertoDesembarque.SelectedItem = SimpleSDK.Enum.CodigosAduana.Puertos.OTROS_PTOS_DE_CHINA;

            var unidadesMedidaTara = ((SimpleSDK.Enum.CodigosAduana.UnidadMedida[])Enum.GetValues(typeof(SimpleSDK.Enum.CodigosAduana.UnidadMedida))).OrderBy(x => x.ToString());
            foreach (var unidadMedidaTara in unidadesMedidaTara) comboUnidadMedidaTara.Items.Add(unidadMedidaTara);

            comboUnidadMedidaTara.SelectedItem = SimpleSDK.Enum.CodigosAduana.UnidadMedida.KLT;

            var unidadesMedidaPeso = ((SimpleSDK.Enum.CodigosAduana.UnidadMedida[])Enum.GetValues(typeof(SimpleSDK.Enum.CodigosAduana.UnidadMedida))).OrderBy(x => x.ToString());
            foreach (var unidadMedidaPeso in unidadesMedidaPeso) comboUnidadMedidaPeso.Items.Add(unidadMedidaPeso);

            comboUnidadMedidaPeso.SelectedItem = SimpleSDK.Enum.CodigosAduana.UnidadMedida.KLT;

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

            var tipoDte = TipoDTE.DTEType.FacturaExportacionElectronica;

            var emisor = new SimpleSDK.Models.DTE.Emisor()
            {
                Rut = textRUTEmisor.Text,
                DireccionOrigen = textDireccionEmisor.Text,
                ComunaOrigen = textComunaEmisor.Text
            };

            var receptor = new SimpleSDK.Models.DTE.Receptor()
            {
                Rut = "55555555-5",
                RazonSocial = textRazonSocialReceptor.Text,
                Direccion = textDireccionReceptor.Text,
                Ciudad = textCiudadReceptor.Text
            };

            Enum.TryParse(comboViaTransporte.SelectedItem.ToString(), out SimpleSDK.Enum.CodigosAduana.ViasdeTransporte codViaTransp);
            Enum.TryParse(comboPuertoEmbarque.SelectedItem.ToString(), out SimpleSDK.Enum.CodigosAduana.Puertos codPtoEmb);
            Enum.TryParse(comboPuertoDesembarque.SelectedItem.ToString(), out SimpleSDK.Enum.CodigosAduana.Puertos codPtoDes);
            Enum.TryParse(comboUnidadMedidaTara.SelectedItem.ToString(), out SimpleSDK.Enum.CodigosAduana.UnidadMedida codUnMedTara);
            Enum.TryParse(comboUnidadMedidaPeso.SelectedItem.ToString(), out SimpleSDK.Enum.CodigosAduana.UnidadMedida codUnMedPesoNeto);
            Enum.TryParse(comboPaisReceptorDestino.SelectedItem.ToString(), out SimpleSDK.Enum.CodigosAduana.Paises codPaisRecep);


            var aduana = new SimpleSDK.Models.DTE.Aduana()
            {
                CodigoModalidadVenta = CodigosAduana.ModalidadVenta.A_FIRME,
                CodigoClausulaVenta = CodigosAduana.ClausulaCompraVenta.CIF,
                TotalClausulaVenta = int.Parse(textClausulaVenta.Text.Replace(".","")),
                CodigoViaTransporte = codViaTransp,
                CodigoPuertoEmbarque = codPtoEmb,
                CodigoPuertoDesembarque = codPtoDes,
                Tara = (int)numericTara.Value,
                CodigoUnidadMedidaTara  = codUnMedTara,
                PesoNeto = (int)numericPesoNeto.Value,
                CodigoUnidadPesoNeto = codUnMedPesoNeto,
                PesoBruto = (int)numericPesoNeto.Value + (int)numericTara.Value,
                CodigoUnidadPesoBruto = codUnMedPesoNeto,
                CantidadBultos = 0,
                MontoFlete = (double)numericFlete.Value,
                MontoSeguro = (double)numericSeguro.Value,
                CodigoPaisReceptor = codPaisRecep,
                CodigoPaisDestino = codPaisRecep,

            };

            var otraMoneda = new SimpleSDK.Models.DTE.OtraMoneda()
            {
                TipoMoneda = CodigosAduana.Moneda.PESO_CHILENO,
                TipoCambio = 800,

            };
            //var bultos = new SimpleSDK.Models.DTE.TipoBulto()
            //{
               //CodigoTipoBulto = CodigosAduana.TipoBultoEnum.CAJON,
               //CantidadBultos = 1,
               //Marcas = "MarcaTest",

            //};

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
                receptor.Ciudad = receptor.Ciudad;
            }

            //Creación del objeto
            var dte = new SimpleSDK.Models.DTE.DTE(emisor, receptor, (int)numericFolio.Value, tipoDte, aduana, otraMoneda);

            //Asignación de detalles
            dte.Exportaciones.Detalles = handler.ItemboletaADetalleExportacion(items);


            dte.CalcularTotalesExportacion(CodigosAduana.Moneda.DOLAR_ESTADOUNIDENSE);


            dte.Certificado.Ruta = textRutaCertificado.Text;
            dte.Certificado.Rut = textRUTCertificado.Text;
            dte.Certificado.Password = textPassword.Text;

            var totalesMontoTotal = dte.Exportaciones.Encabezado.Totales.MontoTotal;
            var otraMonedaTipoCambio = dte.Exportaciones.Encabezado.OtraMoneda.TipoCambio;

            dte.Exportaciones.Encabezado.OtraMoneda.MontoExento = totalesMontoTotal * otraMonedaTipoCambio;
            dte.Exportaciones.Encabezado.OtraMoneda.MontoTotal = dte.Exportaciones.Encabezado.OtraMoneda.MontoExento;


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
            item.Afecto = false;
            item.Precio = (int)numericPrecio.Value;
            item.UnidadMedida = checkUnidad.Checked ? "Kg." : string.Empty;
            items.Add(item);
            gridResultados.DataSource = null;
            gridResultados.DataSource = items;

            textNombre.Text = "";
            numericCantidad.Value = 1;

            calculoTotales();
        }

        private void calculoTotales()
        {
            var totalExento = items.Sum(x => x.Total);

            int totalTotalTotal = totalExento + (int)numericFlete.Value + (int)numericSeguro.Value;

            textValorBienes.Text = totalExento.ToString("N0");

            textClausulaVenta.Text = totalTotalTotal.ToString("N0");

            textFlete.Text = numericFlete.Value.ToString("N0");

            textSeguro.Text = numericSeguro.Value.ToString("N0");
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

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFlete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}