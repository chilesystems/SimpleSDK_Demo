using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using SimpleSDK.Helpers;
using SimpleSDK.Models.Folios;
using SimpleSDK_Demo.Models;

namespace SimpleSDK_Demo
{
    public partial class ConsultarMaximoFolios : Form
    {
        Helper handler = new Helper();
        public ConsultarMaximoFolios(bool certificacion = false)
        {
            InitializeComponent();
            radioCertificacion.Checked = certificacion;
            radioProduccion.Checked = !certificacion;
        }

        private async void ConsultarButton_Click(object sender, EventArgs e)
        {
            Enum.TryParse(comboTipo.SelectedItem.ToString(), out SimpleSDK.Enum.TipoDTE.DTEFoliosType tipoDTE);
            if (tipoDTE == SimpleSDK.Enum.TipoDTE.DTEFoliosType.NotSet)
            {
                MessageBox.Show("Debe seleccionar un tipo de DTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {       
                if (tipoDTE == SimpleSDK.Enum.TipoDTE.DTEFoliosType.BoletaElectronica || tipoDTE == SimpleSDK.Enum.TipoDTE.DTEFoliosType.BoletaElectronicaExenta
                    || tipoDTE == SimpleSDK.Enum.TipoDTE.DTEFoliosType.FacturaElectronicaExenta || tipoDTE == SimpleSDK.Enum.TipoDTE.DTEFoliosType.FacturaExportacionElectronica
                    || tipoDTE == SimpleSDK.Enum.TipoDTE.DTEFoliosType.NotaCreditoExportacionElectronica || tipoDTE == SimpleSDK.Enum.TipoDTE.DTEFoliosType.NotaDebitoExportacionElectronica
                    || tipoDTE == SimpleSDK.Enum.TipoDTE.DTEFoliosType.GuiaDespachoElectronica)
                {
                    MessageBox.Show("El tipo seleccionado no tiene un límite establecido de documentos a descargar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelFoliosDisponibles.Text = "Sin límite";
                    return;
                }
                Loading.ShowLoading(ConsultarButton);

                var rutEmisor = RutEmisorTextBox.Text;
                int ambiente = 1;
                if (radioProduccion.Checked)
                    ambiente = 0;

                var rutaCertificado = handler.Configuracion.Certificado.Ruta;
                var certificado = System.IO.File.ReadAllBytes(rutaCertificado);
                var rutUsuario = handler.Configuracion.Certificado.Rut;
                var password = handler.Configuracion.Certificado.Password;
                var apikey = handler.Configuracion.APIKey;
                var input = new FoliosData
                {
                    RutCertificado = rutUsuario,
                    Password = password,
                    RutEmpresa = rutEmisor,
                    Ambiente = ambiente,
                    CertificadoB64 = certificado,
                    Tipo = (int)tipoDTE,
                };

                var (hasResponse, message, maximoFolios) = await FoliosHelper.ConsultarMaximoFoliosDisponibles(input, apikey);
                if (hasResponse)
                {
                    //var messageBoxMessage = $"Puede solicitar un máximo de {maximoFolios} para DTEs de tipo {tipoDTE}";
                    labelFoliosDisponibles.Text = maximoFolios.ToString("N0");
                }
                else
                {
                    MessageBox.Show($"Ocurrió un error: {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ocurrió un error: {exception.Message + Environment.NewLine + exception.InnerException?.Message ?? ""}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Loading.HideLoading(ConsultarButton);
        }

        private void ConsultarMaximoFolios_Load(object sender, EventArgs e)
        {
            handler.Configuracion = new Configuracion();
            handler.Configuracion.LeerArchivo();
            RutEmisorTextBox.Text = handler.Configuracion.Empresa.RutEmpresa;
            labelFoliosDisponibles.Text = "0";
         

            var tipos = ((SimpleSDK.Enum.TipoDTE.DTEFoliosType[])Enum.GetValues(typeof(SimpleSDK.Enum.TipoDTE.DTEFoliosType))).OrderBy(x => x.ToString());
            foreach (var tipo in tipos) comboTipo.Items.Add(tipo);

            comboTipo.SelectedItem = SimpleSDK.Enum.TipoDTE.DTEFoliosType.NotSet;
        }
    }
}