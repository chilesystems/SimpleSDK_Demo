using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using SimpleSDK.Enum;
using SimpleSDK.Helpers;
using SimpleSDK.Models.RegistroCompraVentas;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class ConsultarRegistroVentas : Form
    {
        Helper handler = new Helper();
        public ConsultarRegistroVentas()
        {
            InitializeComponent();
        }

        private async void buttonConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var fecha = FechaDateTimePicker.Value;
                var mensual = MensualCheckBox.Checked;
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Rut;
                var rutEmpresa = handler.Configuracion.Empresa.RutEmpresa;
                var apikey = handler.Configuracion.APIKey;
            
                RCVData basicData = new RCVData
                {
                    RutUsuario = rutUsuario,
                    Password = password,
                    RutEmpresa = rutEmpresa,
                    Ambiente = (int)Ambiente.AmbienteEnum.Certificacion,
                    CertificadoB64 = certificado,
                    Dia = fecha.Day,
                    Mes = fecha.Month,
                    Anio = fecha.Year
                };
                var (exito, registro) = await RCVHelper.ConsultaRegistroVentasAsync(fecha, mensual, basicData, apikey);
                if (exito)
                {
                    var ventas = registro.Ventas.DetalleVentas;
                    dataGrid1.AutoSize = true;
                    dataGrid1.DataSource = ventas;
                    Console.Write(JsonConvert.SerializeObject(registro));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            
        }

        private void ConsultarRegistroVentas_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmpresaTextBox.Text = handler.Configuracion.Empresa.RutEmpresa;
            RutEmpresaTextBox.Enabled = false;
            RutUsuarioTextBox.Text = handler.Configuracion.Certificado.Rut;
            RutUsuarioTextBox.Enabled = false;        }
    }
}