using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.dominio;
using RecetasSLN.servicio.interfaz;
using RecetasSLN.datos.interfaz;
using RecetasSLN.datos.implementacion;

namespace RecetasSLN.servicio.implementacion
{
    public class Servicio : IServicio
    {
        IPedidoDao dao;
        public Servicio()
        {
            dao = new PedidoDao();
        }

        public void EntregarPedido(int codigo)
        {
            dao.EntregarPedido(codigo);
        }

        public List<Cliente> TraerClientes()
        {
            return dao.TraerClientes();
        }

        public List<Pedido> TraerPedidos(DateTime desde, DateTime hasta, Cliente cliente)
        {
            return dao.TraerPedidos(desde, hasta, cliente);
        }

        public void DarBaja(int codigo)
        {
            dao.DarBaja(codigo);
        }
    }
}
