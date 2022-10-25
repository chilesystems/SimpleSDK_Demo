using Newtonsoft.Json;
using SimpleSDK.Models.Extras;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleSDK_Demo.Models
{
    public class Configuracion
    {
        public Contribuyente Empresa { get; set; }
        public CertificadoDigital Certificado { get; set; }

        public UsuarioSII UsuarioSII { get; set; }
        public string APIKey { get; set; }

        public void GenerarArchivo()
        {
            File.WriteAllText("configuracion.json", JsonConvert.SerializeObject(this), Encoding.GetEncoding("ISO-8859-1"));
        }

        public bool LeerArchivo()
        {
            try
            {
                var conf = JsonConvert.DeserializeObject<Configuracion>(File.ReadAllText("configuracion.json", Encoding.GetEncoding("ISO-8859-1")));
                this.Empresa = conf.Empresa;
                this.Certificado = conf.Certificado;
                this.UsuarioSII = conf.UsuarioSII ?? new UsuarioSII();
                this.APIKey = conf.APIKey;
                return true;
            }
            catch
            {
                InicializarArchivo();
            }
            return false;
        }

        public void InicializarArchivo()
        {
            Contribuyente empresa = new Contribuyente()
            {
                RazonSocial = "RAZÓN SOCIAL",
                Giro = "GIRO GLOSA DESCRIPTIVA",
                Direccion = "DIRECCION 787",
                Comuna = "COMUNA",
                FechaResolucion = new DateTime(2016, 4, 28),
                NumeroResolucion = 0,
                RutEmpresa = "77777777-7",
                CodigosActividades = new List<ActividadEconomica>()
                {
                    new ActividadEconomica() { Codigo =  463020},
                    new ActividadEconomica() { Codigo =  472109},
                    new ActividadEconomica() { Codigo =  472200}
                }
            };

            Empresa = empresa;
            Certificado = new CertificadoDigital()
            {
                Ruta = "path/to/your/certifificate.pfx", //Debe estar en formato .pfx
                Rut = "55555555-5",
                Password = "123123"
            };
            UsuarioSII = new UsuarioSII()
            { 
                RutUsuario = "44444444-4",
                PasswordSII = "123123"
            };
            APIKey = "API-KEY";
            GenerarArchivo();
        }
    }

}
