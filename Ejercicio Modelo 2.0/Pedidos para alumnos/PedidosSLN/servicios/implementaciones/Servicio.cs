using RecetasSLN.datos.Implementaciones;
using RecetasSLN.datos.Interfaces;
using RecetasSLN.dominio;
using RecetasSLN.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.servicios.implementaciones
{
    public class Servicio : IServicio
    {
        IPedidoDAO dao;

        public Servicio()
        {
            dao = new PedidoDAO();
        }

        public void Bajar(int codigo)
        {
            dao.Bajar(codigo);
        }

        public void Entregar(int codigo)
        {
            dao.Entregar(codigo);
        }

        public List<Cliente> ObtenerClientes()
        {
            return dao.ObtenerClientes() ;
        }

        public List<Pedido> ObtenerPedidoPorFiltros(DateTime desde, DateTime hasta, Cliente cliente)
        {
            return dao.ObtenerPedidoPorFiltros(desde,hasta,cliente);

        }


    }
}
