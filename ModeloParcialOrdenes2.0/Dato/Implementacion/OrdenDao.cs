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

        public bool CargarOrden(OrdenRetiro oOrden)
        {
            bool resultado = true;
            SqlTransaction t = null;
            SqlConnection conexion = HelperDB.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "SP_INSERTAR_ORDEN";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.Parameters.AddWithValue("@responsable",oOrden.Responsable);

                SqlParameter p = new SqlParameter();
                p.SqlDbType = SqlDbType.Int;
                p.Direction = ParameterDirection.Output;
                p.ParameterName = "nro";
                comando.Parameters.Add(p);

                int afectadas = comando.ExecuteNonQuery();
                int nroOrden = Convert.ToInt32(p.Value);
                int nroDetalle = 1;
                SqlCommand agregarDetalle;
                foreach (DetalleOrden d in oOrden.DetalleOrden)
                {
                    agregarDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, t);
                    agregarDetalle.CommandType = CommandType.StoredProcedure;
                    agregarDetalle.Parameters.AddWithValue("@nro_orden", nroOrden);
                    agregarDetalle.Parameters.AddWithValue("@detalle",nroDetalle);
                    agregarDetalle.Parameters.AddWithValue("@codigo", d.Material.Codigo);
                    agregarDetalle.Parameters.AddWithValue("@cantidad",d.Cantidad);
                    agregarDetalle.ExecuteNonQuery();
                    //HelperDB.ObtenerInstancia().EjecutarSQL("SP_INSERTAR_DETALLES", lista);
                    nroDetalle++;
                }
                t.Commit();
            }
            catch (SqlException)
            {
                if(t!= null)
                {
                    t.Rollback();
                }
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close(); 
                }
            }
            return resultado;
        }
    }
}
