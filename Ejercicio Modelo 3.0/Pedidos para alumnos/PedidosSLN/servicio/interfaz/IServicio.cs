using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.dominio;

namespace RecetasSLN.servicio.interfaz
{
    public interface IServicio
    {
        List<Cliente> TraerClientes();
        List<Pedido> TraerPedidos(DateTime desde, DateTime hasta, Cliente cliente);
        void EntregarPedido(int codigo);
        void DarBaja(int codigo);
    }
}
