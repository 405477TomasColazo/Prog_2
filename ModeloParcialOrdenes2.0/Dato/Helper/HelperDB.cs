using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace ModeloParcialOrdenes2._0.Dato.Helper
{
    class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection cnn;

        private HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.conexion);
        }

        public static HelperDB ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDB();
            return instancia;
        }
        public int ConsultarEscalar(string nombreSP, string paramSalida)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = paramSalida;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(parametro);
            cmd.ExecuteNonQuery();

            cnn.Close();
            return (int)parametro.Value;
        }
        public DataTable ConsultaSQL(string spNombre, List<Parametro> values)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        public int EjecutarSQL(string strSql, List<Parametro> values)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                if (values != null)
                {
                    foreach (Parametro param in values)
                    {
                        cmd.Parameters.AddWithValue(param.Clave, param.Valor);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return afectadas;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.cnn;
        }
    }
}