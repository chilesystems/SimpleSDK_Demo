using SimpleSDK.Enum;
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
    public partial class ConsultaEstadoDTE : Form
    {
        Helper handler = new Helper();
        public ConsultaEstadoDTE()
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
            int total = int.Parse(textTotal.Text);
            Enum.TryParse(comboTipoDTE.SelectedItem.ToString(), out TipoDTE.DTEType tipoDTE);
            try
            {
                var consulta = new SimpleSDK.Models.Estados.ConsultaDTE(rutEmpresa, rutReceptor)
                {
                    Ambiente = radioCertificacion.Checked ? Ambiente.AmbienteEnum.Certificacion : Ambiente.AmbienteEnum.Certificacion,
                    FechaDTE = dateFechaEmision.Value.Date,
                    Folio = folio,
                    Tipo = (short)tipoDTE,
                    Total = total,
                    ServidorBoletaREST = checkServidorBoleta.Checked,
                    Certificado = handler.Configuracion.Certificado
                };
                consulta.Certificado = handler.Configuracion.Certificado;
                var resultado = await consulta.ConsultarAlSII(handler.Configuracion.APIKey);

                textRespuesta.Text = resultado.Item2.Response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex);
            }
        }
    }
}
