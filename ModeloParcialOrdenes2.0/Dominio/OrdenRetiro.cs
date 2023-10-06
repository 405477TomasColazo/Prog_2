using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialOrdenes2._0.Dominio
{
    public class OrdenRetiro
    {
        public int NroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }
        public List<DetalleOrden> DetalleOrden { get; set; }

        public OrdenRetiro(int nroOrden, DateTime fecha, string responsable, List<DetalleOrden> detalleOrden)
        {
            NroOrden = nroOrden;
            Fecha = fecha;
            Responsable = responsable;
            DetalleOrden = detalleOrden;
        }

        public OrdenRetiro()
        {
            NroOrden = 0;
            Fecha = DateTime.MinValue;
            Responsable = string.Empty;
            DetalleOrden = new List<DetalleOrden>();
        }

        public void AgregarDetalle(DetalleOrden detalle)
        {

            if (detalle != null && detalle.Cantidad > 0)
            {
                DetalleOrden.Add(detalle);
            }
        }
        public void QuitarDetalle(int posicion)
        {
            DetalleOrden.RemoveAt(posicion);
        }
    }
}
