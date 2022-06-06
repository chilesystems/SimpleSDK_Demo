using SimpleSDK.Enum;
using System;
using System.Windows.Forms;

namespace SimpleSDK_Demo
{
    public partial class ConsultaRecepionDTE : Form
    {
        Helper handler = new Helper();
        public ConsultaRecepionDTE()
        {
            InitializeComponent();
        }

        private void ConsultaEstadoDTE_Load(object sender, EventArgs e)
        {
            foreach (var tipo in Enum.GetValues(typeof(TipoDTE.DTEType)))
            {
                comboTipoDTE.Items.Add(tipo);
            }
            handler.Configuracion = new Models.Configuracion();
            handler.Configuracion.LeerArchivo();

            textRUTEmpresa.Text = handler.Configuracion.Empresa.RutCuerpo.ToString();
            textDVEmpresa.Text = handler.Configuracion.Empresa.DV;
            textRUTEnvio.Text = handler.Configuracion.Certificado.RutCuerpo.ToString();
            textDVEnvio.Text = handler.Configuracion.Certificado.DV;

            comboTipoDTE.SelectedIndex = 0;
        }

        private async void botonConsultar_Click(object sender, EventArgs e)
        {
            string rutReceptor = $"{textRUTReceptor.Text}-{textDVReceptor.Text}";
            string rutEmpresa = $"{textRUTEmpresa.Text}-{textDVEmpresa.Text}";
            int folio = int.Parse(textFolio.Text);
            Enum.TryParse(comboTipoDTE.SelectedItem.ToString(), out TipoDTE.DTEType tipoDTE);
            try
            {
                var consulta = new SimpleSDK.Models.Estados.ConsultaRecepcionDTE(rutEmpresa, rutReceptor)
                {
                    Ambiente = radioCertificacion.Checked ? Ambiente.AmbienteEnum.Certificacion : Ambiente.AmbienteEnum.Produccion,
                    Folio = folio,
                    Tipo = (short)tipoDTE,
                    Certificado = handler.Configuracion.Certificado
                };
                consulta.Certificado = handler.Configuracion.Certificado;
                var resultado = await consulta.ConsultarAlSII(handler.Configuracion.APIKey);
                textRespuesta.Text = resultado.Item2.descripcion;
                checkRecibido.Checked = resultado.Item2.isRecibido;
                radioAceptado.Checked = resultado.Item2.isAceptado.HasValue && resultado.Item2.isAceptado.Value;
                radioRechazado.Checked = resultado.Item2.isRechazado.HasValue && resultado.Item2.isRechazado.Value;

                if (radioRechazado.Checked) textRespuesta.Text = "DTE Rechazado";
                else if (radioAceptado.Checked) textRespuesta.Text = "DTE Aceptado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex);
            }
        }
    }
}
