using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloParcialOrdenes2._0.Dato.Interfaz;
using ModeloParcialOrdenes2._0.Dominio;
using System.Data;
using System.Data.SqlClient;
using ModeloParcialOrdenes2._0.Dato.Helper;

namespace ModeloParcialOrdenes2._0.Dato.Implementacion
{
    public class OrdenDao : IOrdenDao
    {
        public List<Material> CargarMateriales()
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_MATERIALES", null);
            List<Material> materiales = new List<Material>();
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = Convert.ToInt32(fila[0]);
                string nombre = fila[1].ToString();
                int stock = Convert.ToInt32(fila[2]);
                Material m = new Material(codigo, nombre, stock);
                materiales.Add(m);
            }
            return materiales;
        }
    }
}
