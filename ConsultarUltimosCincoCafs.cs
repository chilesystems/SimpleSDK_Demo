using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using SimpleSDK.Helpers;
using SimpleSDK.Models.Folios;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class ConsultarUltimosCincoCafs : Form
    {
        Helper handler = new Helper();
        public ConsultarUltimosCincoCafs()
        {
            InitializeComponent();
        }
        private void ConsultarUltimosCincoCafs_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextBox.Text = handler.Configuracion.Empresa.RutEmpresa;
            RutEmisorTextBox.Enabled = false;
        }

        private async void ConsultarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rutEmisor = RutEmisorTextBox.Text;
                var tipoDte = int.Parse(TipoDteTextBox.Text);
                var desde = DesdeDateTimePicker.Value;
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Rut;
                var apikey = handler.Configuracion.APIKey;
                var input = new FoliosData
                {
                    RutCertificado =  rutUsuario,
                    Password = password,
                    RutEmpresa = rutEmisor,
                    Ambiente = 0,
                    CertificadoB64 = certificado,
                    Tipo = tipoDte,
                };
                var (hasResponse, message, infoFolios) = await FoliosHelper.ResumenFolios(desde, input, apikey);
                if (hasResponse)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(infoFolios));
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

    }
}