using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.dominio;
using RecetasSLN.datos;

namespace RecetasSLN.servicio.interfaz
{
    public interface IServicio
    {
        List<Cliente> TraerClientes();
        List<Pedido> TraerPedidos(int idCliente, DateTime fechaMin, DateTime fechaMax);
    }
}
