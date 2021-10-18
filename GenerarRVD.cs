using SimpleSDK_Demo.Models;
using System;
using System.Text;
using System.Windows.Forms;
using SimpleSDK.Helpers;

namespace SimpleSDK_Demo
{
    public partial class GenerarRVD : Form
    {
        Helper handler = new Helper();
        public GenerarRVD()
        {
            InitializeComponent();
        }

        private void GenerarRVD_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
        }

        private async void botonGenerar_ClickAsync(object sender, EventArgs e)
        {
            //Creación del objeto
            var rcof = new SimpleSDK.Models.RCOF.ConsumoFolios()
            {
                Caratula = new SimpleSDK.Models.RCOF.Caratula()
                {
                    FechaEnvio = DateTime.Now,
                    FechaInicio = DateTime.Now, //Fecha Inicio siempre debe ser igual a Fecha Final
                    FechaFinal = DateTime.Now,
                    FechaResolucion = handler.Configuracion.Empresa.FechaResolucion,
                    NroResol = handler.Configuracion.Empresa.NumeroResolucion,
                    RutEmisor = handler.Configuracion.Empresa.RutEmpresa,
                    RutEnvia = handler.Configuracion.Certificado.Rut,
                    SecEnvio = numericSecuencia.Value.ToString()
                },
                Resumenes = new System.Collections.Generic.List<SimpleSDK.Models.RCOF.Resumen>()
                {
                    new SimpleSDK.Models.RCOF.Resumen()
                    {
                        FoliosAnulados = (int)numericFoliosAnulados.Value,
                        FoliosEmitidos = (int) numericFoliosEmitidos.Value,
                        MntExento = (int)numericTotalExento.Value,
                        MntIva = (int)numericTotalIVA.Value,
                        MntNeto = (int)numericTotalNeto.Value,
                        TasaIVA = 19,
                        TipoDocumento = SimpleSDK.Enum.TipoDTE.DTEType.BoletaElectronica
                    }
                },
                Certificado = new SimpleSDK.Models.Extras.CertificadoDigital()
                { 
                    Password = handler.Configuracion.Certificado.Password,
                    Rut = handler.Configuracion.Certificado.Rut,
                    Ruta = handler.Configuracion.Certificado.Ruta
                }
            };

            try
            {
                var result = await rcof.GenerarXMLAsync(handler.Configuracion.APIKey);
                if (result.Item1)
                {
                    var pathDTE = System.IO.Path.Combine(AppContext.BaseDirectory, $"RCOF_{rcof.Caratula.FechaInicio.ToString("ddMMyyyy")}_.xml");
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

        private void numericFoliosAnulados_ValueChanged(object sender, EventArgs e)
        {
            numericAnuladoDesde.Enabled = numericAnuladoHasta.Enabled = numericFoliosAnulados.Value > 0;
        }

        private void numericFoliosEmitidos_ValueChanged(object sender, EventArgs e)
        {
            numericEmitidoDesde.Enabled = numericEmitidoHasta.Enabled = numericFoliosEmitidos.Value > 0;
        }
    }
}
