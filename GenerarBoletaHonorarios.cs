using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.BHE;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class GenerarBoletaHonorarios : Form
    {
        Helper handler = new Helper();
        public GenerarBoletaHonorarios()
        {
            InitializeComponent();
        }

        private void GenerarBoletaHonorarios_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            textRutEmisor.Text = handler.Configuracion.UsuarioSII.RutUsuario;
        }

        private async void GenerarBoletaButton_Click(object sender, EventArgs e)
        {
            try
            {           
                int domicilioIndex = 0;
                if (groupDomicilios.Visible) //Tiene más de un domicilio
                {
                    if (gridDomicilios.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un domicilio de emisor obligatoriamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    domicilioIndex = gridDomicilios.SelectedRows[0].Index + 1;
                }

                Loading.ShowLoading(gridDetalles);
                GenerarBoletaButton.Enabled = false;

                var rutEmisor = textRutEmisor.Text;
                var rutReceptor = textRutReceptor.Text;
                var password = handler.Configuracion.UsuarioSII.PasswordSII;
                TipoRetencionEnum tipoRetencion = RetencionContribuyenteRadioButton.Checked
                    ? TipoRetencionEnum.Contribuyente
                    : TipoRetencionEnum.Receptor;
                var apikey = handler.Configuracion.APIKey;

                // todo detalles
                var input = new BHData
                {
                    RutUsuario =  rutEmisor,
                    PasswordSII = password,
                    Retencion = tipoRetencion,
                    FechaEmision = DateTime.Today,
                    Receptor = new Receptor()
                    { 
                        Comuna = textComuna.Text,
                        Direccion = textDireccion.Text,
                        Nombre = textNombre.Text,
                        Region = (int)numericRegion.Value,
                        Rut = textRutReceptor.Text
                    },
                    Emisor = new Emisor()
                };

                if (domicilioIndex > 0) input.Emisor.Direccion = domicilioIndex;
                for (int i = 0; i < gridDetalles.Rows.Count - 1; i++)
                {
                    input.Detalles.Add(new Detalle() { Nombre = gridDetalles.Rows[i].Cells[0].Value.ToString(), Valor = int.Parse(gridDetalles.Rows[i].Cells[1].Value.ToString()) });
                }

                var (emisionExitosa, message, retorno) = await BHHelper.EmitirAsync(input, apikey);
                if (emisionExitosa)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF|*.pdf";
                    saveFileDialog.FileName = $"BOLETA_HONORARIOS_{retorno.Folio}";
                    saveFileDialog.ShowDialog();
                    if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                    {
                        using (FileStream outputFileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            var bytes = Convert.FromBase64String(retorno.PdfBase64);
                            outputFileStream.Write(bytes, 0, bytes.Length);
                        }
                    }
                    var buttons = MessageBoxButtons.OK;
                    var messageBoxMessage = $"Se emitió correctamente la boleta de honorarios n° {retorno.Folio}";
                    var caption = "Resultado Generación de Boletas de Honorarios";
                    MessageBox.Show(messageBoxMessage, caption, buttons, MessageBoxIcon.Information);
                }
                else
                {
                    try 
                    {
                        var infoBoleta = Newtonsoft.Json.JsonConvert.DeserializeObject<InfoBoleta>(message);                      
                        gridDomicilios.DataSource = infoBoleta.Direcciones.Select(x => new { Value = x }).ToList();
                        groupDomicilios.Visible = true;
                        MessageBox.Show(infoBoleta.message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch 
                    {
                        MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            Loading.HideLoading(gridDetalles);
            GenerarBoletaButton.Enabled = true;
        }
    }
}