using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialOrdenes2._0.Dominio
{
    public class DetalleOrden
    {
        public Material Material { get; set; }
        public int Cantidad { get; set; }

        public DetalleOrden(Material material, int cantidad)
        {
            Material = material;
            Cantidad = cantidad;
        }
    }
}
