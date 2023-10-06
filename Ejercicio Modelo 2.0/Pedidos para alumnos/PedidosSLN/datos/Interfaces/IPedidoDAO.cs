using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.Interfaces
{
    public interface IPedidoDAO
    {
        List<Cliente> ObtenerClientes();
        List<Pedido> ObtenerPedidoPorFiltros(DateTime desde, DateTime hasta, Cliente cliente);

        void Entregar(int codigo);
        void Bajar(int codigo);


    }
}
