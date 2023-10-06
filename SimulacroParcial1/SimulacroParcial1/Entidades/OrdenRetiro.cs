using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1.Entidades
{
    public class OrdenRetiro
    {
        public int nroOrden {  get; set; }
        public DateTime fecha { get; set; }
        public string responsable { get; set; } 
        public List<DetalleOrden> detalleOrden { get; set; }

        public OrdenRetiro(int nroOrden, DateTime fecha, string responsable, List<DetalleOrden> detalleOrden)
        {
            this.nroOrden = nroOrden;
            this.fecha = fecha;
            this.responsable = responsable;
            this.detalleOrden = detalleOrden;
        }

        public OrdenRetiro() 
        {
            this.nroOrden = 0;
            this.fecha = DateTime.MinValue;
            this.responsable = string.Empty;
            detalleOrden = new List<DetalleOrden>();
        }

        public void AgregarDetalle(DetalleOrden detalle)
        {

            if (detalle != null && detalle.cantidad > 0)
            {
                detalleOrden.Add(detalle);
            }
        }
        public void QuitarDetalle(int posicion)
        {
           detalleOrden.RemoveAt(posicion);
        }
    }
}
