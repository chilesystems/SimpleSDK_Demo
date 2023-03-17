using System;
using static SimpleSDK.Enum.TipoImpuesto;

namespace SimpleSDK_Demo.Models
{
    public class ItemBoleta
    {
        public string Nombre { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public int Total { get { return (int)Math.Round(Cantidad * Precio, 0); } }
        public bool Afecto { get; set; }
        public string UnidadMedida { get; set; }
        /// <summary>
        /// Valor en porcentaje
        /// </summary>
        public double Descuento { get; set; }
        public int _tipoImpuesto;
        public TipoImpuestoEnum TipoImpuesto
        {
            get { return _tipoImpuesto != 0 ? (TipoImpuestoEnum)_tipoImpuesto : TipoImpuestoEnum.NotSet; }
            set { _tipoImpuesto = (int)value; }
        }
    }
}
