using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.datos.Interfaz;
using RecetasSLN.dominio;
using RecetasSLN.datos;
using System.Data;
using System.Data.SqlClient;

namespace RecetasSLN.datos.Implementacion
{
    internal class PedidosDao : IPedidosDao
    {
        public bool EliminarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public bool EntregarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_CLIENTES",null);
            foreach (DataRow fila in tabla.Rows)
            {
                int id = Convert.ToInt32(fila["id_cliente"]);
                string nombre = fila["nombre"].ToString();
                string apellido = fila["apellido"].ToString();
                int dni = Convert.ToInt32(fila["dni"]);
                int cPostal = Convert.ToInt32(fila["cod_postal"]);
                Cliente c = new Cliente(id, nombre, apellido, dni, cPostal);
                clientes.Add(c);
            }
            return clientes;
        }

        public List<Pedido> TraerPedidos(int idCliente, DateTime fechaMin, DateTime fechaMax)
        {
            List<Pedido> pedidos = new List<Pedido>();
            List<Parametro> lparams = new List<Parametro>();
            Parametro p1 = new Parametro("@cliente", idCliente);
            Parametro p2 = new Parametro("@fecha_desde", fechaMin);
            Parametro p3 = new Parametro("@fecha_hasta", fechaMax);
            lparams.Add(p1);
            lparams.Add(p2);
            lparams.Add(p3);
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_PEDIDOS", lparams);
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = Convert.ToInt32(fila["codigo"]);
                DateTime fechaEntrega = Convert.ToDateTime(fila["fec_entrega"]);
                string entregado = fila["entrgado"].ToString();
                Pedido p = new Pedido(codigo, fechaEntrega, entregado);
                pedidos.Add(p);
            }
            return pedidos;
        }
    }
}
