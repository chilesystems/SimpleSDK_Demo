using SimpleSDK.Enum;
using SimpleSDK.Models.DTE;
using SimpleSDK_Demo.Models;
using System;
using System.Collections.Generic;

namespace SimpleSDK_Demo
{
    public class Helper
    {
        public Configuracion Configuracion;

        public Helper()
        {
            this.Configuracion = new Configuracion();
        }

        public List<Detalle> ItemboletaADetalle(List<ItemBoleta> items)
        {
            List<Detalle> detalles = new List<Detalle>();
            int contador = 1;
            foreach (var det in items)
            {
                var detalle = new Detalle();
                detalle.NumeroLinea = contador;
                /*IndicadorExento = Sólo aplica si el producto es exento de IVA*/
                detalle.IndicadorExento = det.Afecto ? IndicadorFacturacionExencionEnum.NotSet : IndicadorFacturacionExencionEnum.NoAfectoOExento;

                detalle.Nombre = det.Nombre;
                detalle.Cantidad = (double)det.Cantidad;
                detalle.Precio = det.Precio;
                if (!string.IsNullOrEmpty(det.UnidadMedida))
                {
                    detalle.UnidadMedida = det.UnidadMedida;
                }
                /*Recordar que debe restarse el descuento del detalle y sumarse el recargo*/
                if (det.Descuento != 0)
                {
                    detalle.Descuento = (int)Math.Round(det.Total * (det.Descuento / 100), 0);
                }
                detalle.MontoItem = det.Total - detalle.Descuento;

                if (det.TipoImpuesto != TipoImpuesto.TipoImpuestoEnum.NotSet)
                {
                    detalle.CodigoImpuestoAdicional = new List<TipoImpuesto.TipoImpuestoEnum>
                    {
                        det.TipoImpuesto
                    };
                }
                detalles.Add(detalle);
                contador++;
            }
            return detalles;
        }
        public List<DetalleExportacion> ItemboletaADetalleExportacion(List<ItemBoleta> items)
        {
            List<DetalleExportacion> detalles = new List<DetalleExportacion>();
            int contador = 1;
            foreach (var det in items)
            {
                var detalle = new DetalleExportacion();
                detalle.NumeroLinea = contador;
                /*IndicadorExento = Sólo aplica si el producto es exento de IVA*/
                detalle.IndicadorExento = det.Afecto ? IndicadorFacturacionExencionEnum.NotSet : IndicadorFacturacionExencionEnum.NoAfectoOExento;

                detalle.Nombre = det.Nombre;
                detalle.Cantidad = (double)det.Cantidad;
                detalle.Precio = det.Precio;
                if (!string.IsNullOrEmpty(det.UnidadMedida))
                {
                    detalle.UnidadMedida = det.UnidadMedida;
                }
                /*Recordar que debe restarse el descuento del detalle y sumarse el recargo*/
                if (det.Descuento != 0)
                {
                    detalle.Descuento = (int)Math.Round(det.Total * (det.Descuento / 100), 0);
                }
                detalle.MontoItem = det.Total - detalle.Descuento;

                if (det.TipoImpuesto != TipoImpuesto.TipoImpuestoEnum.NotSet)
                {
                    detalle.CodigoImpuestoAdicional = new List<TipoImpuesto.TipoImpuestoEnum>();
                    detalle.CodigoImpuestoAdicional.Add(det.TipoImpuesto);
                }
                detalles.Add(detalle);
                contador++;
            }
            return detalles;
        }

        public List<ItemBoleta> DetalleAItemBoleta(List<SimpleSDK.Models.DTE.Detalle> items)
        {
            List<ItemBoleta> detalles = new List<ItemBoleta>();
            int contador = 1;
            foreach (var det in items)
            {
                var detalle = new ItemBoleta()
                { 
                    Afecto = det.IndicadorExento == IndicadorFacturacionExencionEnum.NotSet,
                    Cantidad = det.Cantidad,
                    Descuento = det.Descuento,
                    Nombre = det.Nombre,
                    Precio = det.Precio,
                    UnidadMedida = det.UnidadMedida
                };
                detalles.Add(detalle);
                contador++;
            }
            return detalles;
        }

        public Referencia ReferenciaSetdePruebas(string tipoDocumentoReferencia, DateTime? fechaDocReferencia, int? folioReferencia = 0, string casoPrueba = "")
        {
            Referencia referencia = new Referencia();
            if (tipoDocumentoReferencia == "39" || tipoDocumentoReferencia == "41")
            {
                referencia = new Referencia()
                {
                    CodigoReferencia = TipoReferencia.TipoReferenciaEnum.SetPruebas,
                    Numero = 1,
                    RazonReferencia = casoPrueba,
                };
            }
            else
            {
                referencia = new Referencia()
                {
                    FechaDocumentoReferencia = fechaDocReferencia.HasValue ? fechaDocReferencia.Value : default,
                    FolioReferencia = folioReferencia.ToString(),
                    Numero = 1,
                    RazonReferencia = casoPrueba
                };
            }
            return referencia;
        }
    }
}
