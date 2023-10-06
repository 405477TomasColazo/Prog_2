using RecetasSLN.datos;
using RecetasSLN.datos.Interfaces;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace RecetasSLN.datos.Implementaciones
{
    public class PedidoDAO : IPedidoDAO
    {
        public void Bajar(int codigo)
        {
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@codigo", codigo));
            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL("SP_REGISTRAR_BAJA", lista);
            if (afectadas == 0)
            {
                MessageBox.Show("El pedido ya esta dado de baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Se dio de baja el pedido ", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void Entregar(int codigo)
        {

            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@codigo", codigo));
            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL("SP_REGISTRAR_ENTREGA", lista);
            if(afectadas == 0)
            {
                MessageBox.Show("El producto ya se encuentra entregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Se entregó el producto. ", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> lstClientes = new List<Cliente> ();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_CLIENTES", null);

            foreach (DataRow fila in tabla.Rows)
            {
                int id = Convert.ToInt32(fila["id_cliente"]);
                string nombre = fila["nombre"].ToString();
                string apellido = fila["apellido"].ToString();
                int dni = Convert.ToInt32(fila["dni"]);
                int postal = Convert.ToInt32(fila["cod_postal"]);
                DateTime desde = Convert.ToDateTime("01/01/1900");
                DateTime hasta = DateTime.Now;

                List<Parametro> lista = new List<Parametro>();
                lista.Add(new Parametro("@cliente", id));
                lista.Add(new Parametro("@fecha_desde", desde));
                lista.Add(new Parametro("@fecha_hasta", hasta));
                
                List<Pedido> lstPedidos = new List<Pedido>();

                DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_PEDIDOS", lista);
                foreach (DataRow fila1 in t.Rows)
                {
                    if (fila1["fecha_baja"] == DBNull.Value) 
                    {
                        int codigo = Convert.ToInt32(fila1["codigo"]);
                        DateTime fecha_entrega = Convert.ToDateTime(fila1["fec_entrega"]);
                        string direccion = fila1["dir_entrega"].ToString();
                        string entregado = fila1["entregado"].ToString();
                        Pedido p = new Pedido(codigo, fecha_entrega, direccion, entregado);
                        lstPedidos.Add(p);

                    }

                    else
                    {
                        int codigo = Convert.ToInt32(fila1["codigo"]);
                        DateTime fecha_entrega = Convert.ToDateTime(fila1["fec_entrega"]);
                        string direccion = fila1["dir_entrega"].ToString();
                        DateTime fecha_baja = Convert.ToDateTime(fila1["fecha_baja"]);
                        string entregado = fila1["entregado"].ToString();
                        Pedido p = new Pedido(codigo, fecha_entrega, direccion, fecha_baja, entregado);
                        lstPedidos.Add(p);
                    }
                    
                }

                Cliente c = new Cliente(id, nombre, apellido, dni, postal, lstPedidos);
                lstClientes.Add(c);

            }
            return lstClientes;
        }

        public List<Pedido> ObtenerPedidoPorFiltros(DateTime desde, DateTime hasta, Cliente cliente)
        {

            List<Pedido> lstPedidos = new List<Pedido>();
            foreach (Pedido p in cliente.Pedidos)
            {
                if (p.FechaEntrega >= desde && p.FechaEntrega <= hasta) lstPedidos.Add(p);
            }
            
            return lstPedidos;
        }
    }
}
