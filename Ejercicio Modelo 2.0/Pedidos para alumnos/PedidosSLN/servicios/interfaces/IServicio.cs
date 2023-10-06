using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.servicios.interfaces
{
    public interface IServicio
    {
        List<Cliente> ObtenerClientes();
        List<Pedido> ObtenerPedidoPorFiltros(DateTime desde, DateTime hasta, Cliente cliente);

        void Entregar(int codigo);
        void Bajar(int codigo);


    }
}
