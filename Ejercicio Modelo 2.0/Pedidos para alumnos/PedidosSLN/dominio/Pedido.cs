using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string direccionEntrega { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Entregado { get; set; }

        public Pedido(int codigo,DateTime entrega, string direccion, DateTime baja, string entregado)
        {
            this.FechaBaja = baja;
            this.Codigo = codigo;
            this.direccionEntrega = direccion;
            this.Entregado = entregado;
            this.FechaEntrega = entrega;
        }

        public Pedido(int codigo, DateTime entrega, string direccion, string entregado)
        {
            this.Codigo = codigo;
            this.direccionEntrega = direccion;
            this.Entregado = entregado;
            this.FechaEntrega = entrega;
        }
    }
}
