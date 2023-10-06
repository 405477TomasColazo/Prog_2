using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialOrdenes.Dominio
{
    internal class DetalleOrden
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
