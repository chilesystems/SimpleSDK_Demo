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
        public ConsultarRegistroVentas(bool certificacion = false)
        {
            InitializeComponent();
            radioCertificacion.Checked = certificacion;
            radioProduccion.Checked = !certificacion;
        }

        private async void buttonConsultar_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(dataGrid1);
            buttonConsultar.Enabled = false;
            try
            {
                var fecha = FechaDateTimePicker.Value;
                var mensual = MensualCheckBox.Checked;
                /*var rutUsuario = RutUsuarioTextBox.Text;
                var password = handler.Configuracion.UsuarioSII.PasswordSII;*/
                var rutEmpresa = RutEmpresaTextBox.Text;
                var apikey = handler.Configuracion.APIKey;
                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var rutCertificado = handler.Configuracion.Certificado.Rut;
                var passwordCertificado = handler.Configuracion.Certificado.Password;

                byte[] certBytes = System.IO.File.ReadAllBytes(rutaCertificado);
                string nombreCertificado = System.IO.Path.GetFileName(rutaCertificado);
                BasicData basicData = new BasicData
                {
                    //RutUsuario =  rutUsuario,
                    //PasswordSII = password,
                    CertificadoB64 = certBytes,
                    Password = passwordCertificado,
                    RutCertificado = rutCertificado,
                    RutEmpresa = rutEmpresa,
                    Ambiente = radioCertificacion.Checked ? 0 : 1

                };
                var (exito, registro) = await RCVHelper.ConsultaRegistroVentasAsync(fecha, mensual, basicData, apikey, nombreCertificado);
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
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Loading.HideLoading(dataGrid1);
            buttonConsultar.Enabled = true;

        }

        private void ConsultarRegistroVentas_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmpresaTextBox.Text = handler.Configuracion.Empresa.RutEmpresa;
            //RutUsuarioTextBox.Text = handler.Configuracion.UsuarioSII.RutUsuario;
            MensualCheckBox.Checked = true;
        }

        private void MensualCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FechaDateTimePicker.CustomFormat = MensualCheckBox.Checked ? "MM/yyyy" : "dd/MM/yyyy";
        }
    }
}