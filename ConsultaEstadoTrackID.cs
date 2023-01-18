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

namespace SimpleSDK_Demo
{
    public partial class ConsultaEstadoTrackID : Form
    {
        Helper handler = new Helper();
        public ConsultaEstadoTrackID()
        {
            InitializeComponent();
        }

        private void ConsultaEstadoTrackID_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Models.Configuracion();
            handler.Configuracion.LeerArchivo();

            textRUTEmpresa.Text = handler.Configuracion.Empresa.RutCuerpo.ToString();
            textDVEmpresa.Text = handler.Configuracion.Empresa.DV;
        }

        private async void botonConsultar_Click(object sender, EventArgs e)
        {
            long trackId = long.Parse(textTrackID.Text);
            string rutEmpresa = $"{textRUTEmpresa.Text}-{textDVEmpresa.Text}";
            
            try
            {
                var consulta = new SimpleSDK.Models.Estados.ConsultaTrackID(rutEmpresa)
                {
                    Ambiente = radioCertificacion.Checked ? Ambiente.AmbienteEnum.Certificacion : Ambiente.AmbienteEnum.Produccion,
                    Certificado = handler.Configuracion.Certificado,
                    TrackId = trackId,
                    ServidorBoletaREST = radioEnvioBoleta.Checked
                };

                if (radioEnvioBoleta.Checked)
                {
                    var resultado = await consulta.ConsultarBoletasAlSII(handler.Configuracion.APIKey);
                    textRespuesta.Text = resultado.respuesta.ToString();
                }
                else
                {
                    var resultado = await consulta.ConsultarAlSII(handler.Configuracion.APIKey);
                    textRespuesta.Text = resultado.respuesta.ResponseXml ?? resultado.respuesta.Response;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex);
            }
        }
    }
}
