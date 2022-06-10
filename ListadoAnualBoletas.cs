using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using SimpleSDK.Helpers;
using SimpleSDK.Models.RegistroCompraVentas;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class ListadoAnualBoletas : Form
    {
        Helper handler = new Helper();
        public ListadoAnualBoletas()
        {
            InitializeComponent();
        }

        private void ListadoAnualBoletas_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextbox.Text = handler.Configuracion.Certificado.Rut;
            RutEmisorTextbox.Enabled = false;
        }

        private async void ListadoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                string tipo = "";
                if (RecibidaRadioButton.Checked)
                    tipo = "recibidas";
                else if (EmitidaRadioButton.Checked)
                    tipo = "emitidas";
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Rut;
                var apikey = handler.Configuracion.APIKey;
                var anio = int.Parse(AnioTextbox.Text);
                var basicData = new BasicData
                {
                    RutCertificado =  rutUsuario,
                    Password = password,
                    CertificadoB64 = certificado
                };
                var resumenAnual = await BHHelper.ObtenerListadoAnualAsync(basicData, tipo, anio, apikey);
                Console.WriteLine(JsonConvert.SerializeObject(resumenAnual));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}