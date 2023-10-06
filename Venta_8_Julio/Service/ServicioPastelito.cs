using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_8_Julio.Data;
using System.Data;

namespace Venta_8_Julio.Service
{
    public class ServicioPastelito
    {
        private AccesoDatos oBD;
        public ServicioPastelito()
        {
            oBD = new AccesoDatos();
        }

        public List<Vendedor> TraerVendedores()
        {
            List<Vendedor> lv = new List<Vendedor>();
            DataTable dt = oBD.ConsultarBD("Select * from vendedores");
            foreach (DataRow fila in dt.Rows)
            {
                Vendedor v = new Vendedor();
                v.Id_Vendedor = Convert.ToInt32(fila[0]);
                v.Nombre = Convert.ToString(fila[1]);
                v.Apellido = Convert.ToString(fila[3]);
                v.Id_patrulla = Convert.ToInt32(fila[2]);
                lv.Add(v);
            }
            return lv;
        }

        internal List<Cliente> TraerClientes()
        {
            List<Cliente> lc = new List<Cliente>();
            DataTable dt = new DataTable();
            foreach (DataRow fila in dt.Rows)
            {
                Cliente c = new Cliente();
                c.Id_cliente = Convert.ToInt32(fila[0]);
                c.Id_Vendedor = Convert.ToInt32(fila[1]);
                c.Nombre = fila[2].ToString();
                lc.Add(c);
            }
            return lc;
        }
    }
}
