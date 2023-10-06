using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public int CodigoPostal { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }
        public Cliente(int id, string nombre,string apellido, int dni, int codigoPostal, List<Pedido> pedidos)
        {
            Pedidos = new List<Pedido>();
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            CodigoPostal = codigoPostal;
            Id = id;
            Pedidos = pedidos;
        }

        public void AgregarPedido(Pedido oPedido)
        {
            if (oPedido != null)
                Pedidos.Add(oPedido);
        }

        public void QuitarPedido(Pedido oPedido)
        {
            if (oPedido != null)
                Pedidos.Remove(oPedido);
        }
    }
}
