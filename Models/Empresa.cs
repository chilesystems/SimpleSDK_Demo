using System;
using System.Collections.Generic;

namespace SimpleSDK_Demo.Models
{
    public class Contribuyente
    {
        public string RutEmpresa { get; set; }
        public string RazonSocial { get; set; }
        public string Giro { get; set; }
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        public List<ActividadEconomica> CodigosActividades { get; set; }
        public DateTime FechaResolucion { get; set; }
        public int NumeroResolucion { get; set; }

        public int RutCuerpo { get { return int.Parse(RutEmpresa.Substring(0, RutEmpresa.Length - 2)); } }
        public string DV { get { return RutEmpresa.Substring(RutEmpresa.Length - 1, 1); } }

    }

    public class ActividadEconomica
    {
        public int Codigo { get; set; }
    }
}
