using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.dominio;

namespace RecetasSLN.datos.Interfaz
{
    internal interface IPedidosDao
    {
        bool EntregarPedido(Pedido pedido);
        bool EliminarPedido(Pedido pedido);
        List<Pedido> TraerPedidos(int idCliente, DateTime fechaMin, DateTime fechaMax);
        List<Cliente> TraerClientes();
    }
}
