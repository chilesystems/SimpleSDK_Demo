using SimpleSDK_Demo.Models;
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
using SimpleSDK.Helpers;
using SimpleSDK.Enum;

namespace SimpleSDK_Demo
{
    public partial class Main : Form
    {
        Helper handler = new Helper();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            handler.Configuracion.LeerArchivo();
            comboTipoEnvio.SelectedIndex = 0;
        }

        private void botonGenerarDocumento_Click(object sender, EventArgs e)
        {
            GenerarDocumentoElectronico formulario = new GenerarDocumentoElectronico();
            formulario.Show();
        }

        private void botonConfiguracion_Click(object sender, EventArgs e)
        {
            ConfiguracionDemo formulario = new ConfiguracionDemo();
            formulario.Show();
        }

        private async void botonCesion_ClickAsync(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Seleccione DTE para ser cedido";
            openFileDialog.Filter = "Archivos DTE (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                /*La cesión se debe realizar a partir de un DTE existente
                 Para ello, se carga el correspondiente XML.*/
                string pathDTECedido = openFileDialog.FileName;

                /*Datos del factoring*/
                var cesionario = new SimpleSDK.Models.Cesion.Cesionario()
                {
                    Direccion = "Dirección Cesionario",
                    eMail = "Email Cesionario",
                    RazonSocial = "Factoring LTDA",
                    RUT = "11111111-1"
                };

                var cedente = new SimpleSDK.Models.Cesion.Cedente()
                {
                    RUT = "22222222-2",
                    RazonSocial = "Razón Social",
                    Direccion = "Dirección",
                    eMail = "Email",
                    RUTsAutorizados = new List<SimpleSDK.Models.Cesion.RUTAutorizado>()
                    {
                        new SimpleSDK.Models.Cesion.RUTAutorizado()
                        {
                            Nombre = "Nombre Autorizado",
                            RUT = "RUT Autorizado"
                        }
                    }
                };

                var cesion = new SimpleSDK.Models.Cesion.Cesion();
                cesion.Cesionario = cesionario;
                cesion.Cedente = cedente;

                /*Creo el objeto AEC*/
                var AEC = new SimpleSDK.Models.Cesion.AEC();
                AEC.DocumentoAEC.Cesiones.Add(cesion);

                AEC.Certificado.Ruta = handler.Configuracion.Certificado.Ruta;
                AEC.Certificado.Rut = handler.Configuracion.Certificado.Rut;
                AEC.Certificado.Password = handler.Configuracion.Certificado.Password;

                var result = await AEC.GenerarXMLAsync(pathDTECedido, handler.Configuracion.APIKey);

                if (result.Item1)
                {
                    var pathDTE = System.IO.Path.Combine(AppContext.BaseDirectory, $"AEC_{cesionario.RUT}_{DateTime.Now.Ticks}.xml");
                    System.IO.File.WriteAllText(pathDTE, result.Item2, Encoding.GetEncoding("ISO-8859-1"));
                    MessageBox.Show($"Documento AEC generado exitosamente y guardado en {pathDTE}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private async void botonEnviarSii_Click(object sender, EventArgs e)
        {
            /* Todo envío al SII debe realizarse mediante un XML denominado "Sobre de Envío" o también "EnvioDTE"
             * Un EnvioDTE es un XML que puede albergar hasta 2.000 DTE individuales, para enviarlos todos de forma
             * masiva en un solo archivo.
             * Solamente las boletas deben enviarse mediante otro XML denominado "EnvioBoleta", que cumple con exactamente
             * la misma función que el EnvioDTE. En este caso, soporta un máximo de 500 DTEs de boleta a la vez. Recomendamos 
             * que no sean más de 100.   
             * Otros archivos que se pueden enviar al SII son el RVD y LCV (Libros), para ello se usan los mismos endpoints que para EnvioDTE.
             */

            /*************Generación del sobre*************/

            var envioSII = new SimpleSDK.Models.Envios.EnvioSII();
            envioSII.Ambiente = radioCertificacion.Checked ? Ambiente.AmbienteEnum.Certificacion : Ambiente.AmbienteEnum.Produccion;

            /*Datos del certificado*/
            envioSII.Certificado.Ruta = handler.Configuracion.Certificado.Ruta;
            envioSII.Certificado.Rut = handler.Configuracion.Certificado.Rut;
            envioSII.Certificado.Password = handler.Configuracion.Certificado.Password;

            if (comboTipoEnvio.SelectedIndex == 0) envioSII.Tipo = TipoEnvio.EnvioType.EnvioDTE;
            else if (comboTipoEnvio.SelectedIndex == 1) envioSII.Tipo = TipoEnvio.EnvioType.EnvioBoleta;
            else if (comboTipoEnvio.SelectedIndex == 2) envioSII.Tipo = TipoEnvio.EnvioType.RVD;
            else if (comboTipoEnvio.SelectedIndex == 3) envioSII.Tipo = TipoEnvio.EnvioType.LVC;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = $"Seleccione archivo para ser enviado al SII";
            openFileDialog.Filter = $"Archivo XML (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathFile = openFileDialog.FileName;
                var result = await envioSII.EnviarSIIAsync(pathFile, handler.Configuracion.APIKey);
                if (envioSII.Tipo == TipoEnvio.EnvioType.EnvioBoleta)
                {
                    ResultadoOperacion formulario = new ResultadoOperacion(result.Item2.ToString());
                    formulario.ShowDialog();
                }
                else
                {
                    ResultadoOperacion formulario = new ResultadoOperacion(result.Item2.ResponseXml);
                    formulario.ShowDialog();
                }
               
            }
        }

        private async void botonFacturaCompra_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Seleccione CAF para generar DTE Factura de Compra";
            openFileDialog.Filter = "Archivos DTE (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathCAF = openFileDialog.FileName;
                var emisor = new SimpleSDK.Models.DTE.Emisor()
                {
                    Rut = handler.Configuracion.Empresa.RutEmpresa,
                    DireccionOrigen = handler.Configuracion.Empresa.Direccion,
                    ComunaOrigen = handler.Configuracion.Empresa.Comuna,
                    CiudadOrigen = handler.Configuracion.Empresa.Comuna,
                    RazonSocial = handler.Configuracion.Empresa.RazonSocial,
                    Giro = handler.Configuracion.Empresa.Giro,
                    CorreoElectronico = "test@simple-api.cl",
                    Telefono = new List<string>() { "123123123" },
                    ActividadEconomica = handler.Configuracion.Empresa.CodigosActividades.Select(x=>x.Codigo).ToList()
                };

                var receptor = new SimpleSDK.Models.DTE.Receptor()
                {
                    Rut = "17096073-4",
                    RazonSocial = "GONZALO BUSTAMANTE BAÑADOS",
                    Direccion = "DIRECCION 123",
                    Comuna = "COMUNA DE CHILE",
                    Giro = "GIRO DEL RECEPTOR"
                };

                long folio = 1; //Valor debe ser cambiado por el que corresponda
                                 //Creación del objeto
                var dte = new SimpleSDK.Models.DTE.DTE(emisor, receptor, folio, TipoDTE.DTEType.FacturaCompraElectronica);

                //Asignación de detalles
                List<ItemBoleta> items = new List<ItemBoleta>()
            {
                new ItemBoleta(){
                    Afecto = true,
                    Cantidad = 1,
                    Nombre = "ITEM DE PRUEBA",
                    Precio = 5000
                },
                new ItemBoleta(){
                    Afecto = false,
                    Cantidad = 1,
                    Nombre = "EXENTO DE PRUEBA",
                    Precio = 2500
                }
            };
                dte.Documento.Detalles = handler.ItemboletaADetalle(items);

                dte.CalcularTotales();

                dte.Certificado.Ruta = handler.Configuracion.Certificado.Ruta;
                dte.Certificado.Rut = handler.Configuracion.Certificado.Rut;
                dte.Certificado.Password = handler.Configuracion.Certificado.Password;

                try
                {
                    var result = await dte.GenerarXMLAsync(pathCAF, handler.Configuracion.APIKey);
                    if (result.Item1)
                    {
                        var pathDTE = System.IO.Path.Combine(AppContext.BaseDirectory, $"DTE_46_{emisor.Rut}_{folio}.xml");
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
            }

            
        }

        private void botonGenerarNotaCredito_Click(object sender, EventArgs e)
        {
            GenerarNotaCredito formulario = new GenerarNotaCredito();
            formulario.Show();
        }

        private void botonGenerarRCOF_Click(object sender, EventArgs e)
        {
            GenerarRVD formulario = new GenerarRVD();
            formulario.Show();
        }

        private async void botonLibroGuias_ClickAsync(object sender, EventArgs e)
        {
            var libro = new SimpleSDK.Models.LCV.LibroGuia();
            libro.Id = $"ID_{DateTime.Now.Ticks}";

            libro.Caratula = new SimpleSDK.Models.LCV.Caratula()
            {
                RutEmisor = handler.Configuracion.Empresa.RutEmpresa,
                RutEnvia = handler.Configuracion.Certificado.Rut,
                PeriodoTributario = DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("D2"),
                FechaResolucion = handler.Configuracion.Empresa.FechaResolucion,
                NumeroResolucion = handler.Configuracion.Empresa.NumeroResolucion,
                TipoLibro = TipoLibro.TipoLibroEnum.Especial,
                TipoEnvio = TipoEnvioLibro.TipoEnvioLibroEnum.Total,
                FolioNotificacion = 1
            };

            //Los datos se deben llenar según corresponda.

            libro.ResumenPeriodo = new SimpleSDK.Models.LCV.ResumenPeriodo()
            {
                TotalesGuiasDeVentas = 1,
                MontoTotalVentasGuia = 20000,
                TotalesGuiasAnuladas = 0, //Dato opcional. No hay un indicador en el DTE para establecer que está anulado. Se debe entregar según datos del propio desarrollador,
                TotalesFoliosAnulados = 0, //Dato opcional. No hay un indicador en el DTE para establecer que su folio está anulado. Se debe entregar según datos del propio desarrollador,               

                //El traslado es opcional. Se repite hasta 6 veces, según los códigos de NO venta (2, 3, 4, 5, 6, 7).
                Traslados = new List<SimpleSDK.Models.LCV.TotalTraslado>()
                {
                    new SimpleSDK.Models.LCV.TotalTraslado
                    {
                        TipoTraslado = TipoTraslado.TipoTrasladoEnum.TrasladosInternos,
                        CantidadGuia = 1,
                        MontoGuia = 0
                    }
                }
            };

            libro.Detalles = new List<SimpleSDK.Models.LCV.Detalle>();
            libro.Detalles.Add(new SimpleSDK.Models.LCV.Detalle()
            {
                MontoTotal = 20000,
                Folio = 50,
                TipoOperacion = TipoTraslado.TipoTrasladoEnum.OperacionConstituyeVenta,
            });

            libro.Certificado = new SimpleSDK.Models.Extras.CertificadoDigital()
            {
                Password = handler.Configuracion.Certificado.Password,
                Rut = handler.Configuracion.Certificado.Rut,
                Ruta = handler.Configuracion.Certificado.Ruta
            };

            var result = await libro.GenerarXMLAsync(handler.Configuracion.APIKey);
            var pathLibro = System.IO.Path.Combine(AppContext.BaseDirectory, $"LibroGuias_{libro.Caratula.RutEmisor}.xml");
            if (result.Item1)
            {                
                System.IO.File.WriteAllText(pathLibro, result.Item2, Encoding.GetEncoding("ISO-8859-1"));
                MessageBox.Show($"Libro de Guias generado exitosamente y guardado en {pathLibro}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracionDemo formulario = new ConfiguracionDemo();
            formulario.Show();
        }

        private async void botonGenerarSobreEnvio_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Seleccione DTEs para enviar al SII";
            openFileDialog.Filter = "Archivos DTE (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var envioSII = new SimpleSDK.Models.Envios.SobreEnvio();

                envioSII.Certificado.Ruta = handler.Configuracion.Certificado.Ruta;
                envioSII.Certificado.Rut = handler.Configuracion.Certificado.Rut;
                envioSII.Certificado.Password = handler.Configuracion.Certificado.Password;

                /*Estos valores se deben cambiar por los que correspondan*/
                envioSII.Caratula.RutEmisor = handler.Configuracion.Empresa.RutEmpresa;
                envioSII.Caratula.RutReceptor = "60803000-K"; //Si es al SII, debe ir "60803000-K". Si es al cliente, el rut del cliente
                envioSII.Caratula.FechaResolucion = handler.Configuracion.Empresa.FechaResolucion;
                envioSII.Caratula.NumeroResolucion = handler.Configuracion.Empresa.NumeroResolucion;

                string[] pathFiles = openFileDialog.FileNames;
                var result = await envioSII.GenerarXMLAsync(pathFiles, handler.Configuracion.APIKey);

                string pathEnvio = string.Empty;
                if (result.Item1)
                {
                    pathEnvio = Path.Combine(AppContext.BaseDirectory, $"EnvioSII_{envioSII.Caratula.RutEmisor}_{pathFiles.Count()}_dtes_{DateTime.Now.Ticks}.xml");
                    File.WriteAllText(pathEnvio, result.Item2, Encoding.GetEncoding("ISO-8859-1"));
                    MessageBox.Show($"Documento EnvioDTE generado exitosamente y guardado en {pathEnvio}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void botonConsultarEstadoDTE_Click(object sender, EventArgs e)
        {
            ConsultaEstadoDTE formulario = new ConsultaEstadoDTE();
            formulario.ShowDialog();
        }

        private void botonConsultarEstadoEnvio_Click(object sender, EventArgs e)
        {
            ConsultaEstadoTrackID formulario = new ConsultaEstadoTrackID();
            formulario.ShowDialog();
        }

        private void botonValidador_Click(object sender, EventArgs e)
        {
            Validador formulario = new Validador();
            formulario.ShowDialog();
        }

        private void botonTimbre_Click(object sender, EventArgs e)
        {
            MuestraTimbre formulario = new MuestraTimbre();
            formulario.ShowDialog();
        }

        private void botonMuestraImpresa_Click(object sender, EventArgs e)
        {
            MuestraImpresa formulario = new MuestraImpresa();
            formulario.ShowDialog();
        }

        private void RegistroComprasButton_Click(object sender, EventArgs e)
        {
            var formulario = new ConsultarRegistroCompras();
            formulario.ShowDialog();
        }

        private void CrearBoletaHonorariosButton_Click(object sender, EventArgs e)
        {
            var formulario = new GenerarBoletaHonorarios();
            formulario.ShowDialog();
        }

        private void AnulaBoletaHonorarioButton_Click(object sender, EventArgs e)
        {
            var formulario = new AnularBoleta();
            formulario.ShowDialog();        
        }

        private void DownloadPdfButton_Click(object sender, EventArgs e)
        {
            var formulario = new ObtenerPdfBoleta();
            formulario.ShowDialog();
        }
    }
}
