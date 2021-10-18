using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleSDK_Demo
{
    public partial class ResultadoOperacion : Form
    {
        private string texto;
        public ResultadoOperacion(string texto)
        {
            this.texto = texto;
            InitializeComponent();
        }

        private void ResultadoOperacion_Load(object sender, EventArgs e)
        {
            try 
            {
                XDocument doc = XDocument.Parse(texto);
                textRespuesta.Text = doc.ToString();
            }
            catch 
            {                
                dynamic parsedJson = JsonConvert.DeserializeObject(texto);
                textRespuesta.Text = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
        }
    }
}
