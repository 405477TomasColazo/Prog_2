using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.datos.interfaz;
using RecetasSLN.dominio;
using System.Data;
using System.Data.SqlClient;
using RecetasSLN.datos;
using System.Windows.Forms;

namespace RecetasSLN.datos.implementacion
{
    public class PedidoDao : IPedidoDao
    {
        public void DarBaja(int codigo)
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@codigo", codigo));
            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL("SP_REGISTRAR_BAJA",parametros);
            if(afectadas == 0)
            {
                MessageBox.Show("El pedido ya fue dado de baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El pedido se dio de baja con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void EntregarPedido(int codigo)
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@codigo", codigo));
            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL("SP_REGISTRAR_ENTREGA", parametros);
            if (afectadas == 0)
            {
                MessageBox.Show("El pedido ya fue entregado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El pedido se entrego con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_CLIENTES", null);
            foreach (DataRow fila in tabla.Rows)
            {
                int id = Convert.ToInt32(fila[0]);
                string nombre = fila[1].ToString();
                string apellido = fila[2].ToString();
                int dni = Convert.ToInt32(fila[3]);
                int codigoPostal = Convert.ToInt32(fila[4]);
                DateTime desde = Convert.ToDateTime("01-01-1900");
                DateTime hasta = DateTime.Now;
                List<Parametro> lstParametros = new List<Parametro>();
                lstParametros.Add(new Parametro("@cliente", id));
                lstParametros.Add(new Parametro("@fecha_desde", desde));
                lstParametros.Add(new Parametro("@fecha_hasta", hasta));

                List<Pedido> pedidos = new List<Pedido>();
                DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_PEDIDOS", lstParametros);
                foreach (DataRow dr in dt.Rows)
                {
                    Pedido p;
                    int codigo = Convert.ToInt32(dr[0]);
                    DateTime fechaEntrega = Convert.ToDateTime(dr[1]);
                    string direccion = Convert.ToString(dr[2]);
                    string entregado = Convert.ToString(dr[4]);                   
                    if (dr["fecha_baja"] == DBNull.Value)
                    {
                        p = new Pedido(codigo,fechaEntrega,direccion,entregado);
                    }
                    else
                    {
                        p = new Pedido(codigo, fechaEntrega, direccion, entregado,Convert.ToDateTime(dr[5]));
                    }
                    pedidos.Add(p);
                }
                Cliente c = new Cliente(id, nombre, apellido, dni, codigoPostal, pedidos);
                clientes.Add(c);
            }
            return clientes;
        }

        public List<Pedido> TraerPedidos(DateTime desde, DateTime hasta, Cliente cliente)
        {
            List<Pedido> pedidos = new List<Pedido>();
            foreach (Pedido p in cliente.Pedidos)
            {
                if(p.FechaEntrega >= desde && p.FechaEntrega <= hasta)
                {
                    pedidos.Add(p);
                }
            }
            return pedidos;
        }
    }
}
