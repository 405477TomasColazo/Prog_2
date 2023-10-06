using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.dominio;
using RecetasSLN.servicio.interfaz;
using RecetasSLN.datos.Implementacion;
using RecetasSLN.datos.Interfaz;
using RecetasSLN.datos;

namespace RecetasSLN.servicio.implementacion
{
    public class Servicio : IServicio
    {
        private IPedidosDao dao;
        public Servicio()
        {
            dao = new PedidosDao();
        }
        public List<Cliente> TraerClientes()
        {
            return dao.TraerClientes();
        }

        public List<Pedido> TraerPedidos(int idCliente, DateTime fechaMin, DateTime fechaMax)
        {
            return dao.TraerPedidos(idCliente,fechaMin,fechaMax);
        }
    }
}
