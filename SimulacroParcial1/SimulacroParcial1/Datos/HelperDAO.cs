using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace SimulacroParcial1.Datos
{
    public class HelperDAO
    {
        private static HelperDAO instancia;
        private SqlConnection conexion;

        private HelperDAO() 
        {
            conexion = new SqlConnection(Properties.Resources.CadenaConexion);
        }

        public static HelperDAO ObtenerInstancia()   
        { 
            if (instancia == null) 
            { 
                instancia = new HelperDAO();
            }
            return instancia;
        }

        public int ConsultarEscalar(string nombreSP, string paramSalida)
        { 
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = paramSalida;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(parametro);
            cmd.ExecuteNonQuery();

            conexion.Close();
            return (int)parametro.Value;
        }

        public DataTable Consultar(string nombreSP)
        {   
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public DataTable Consultar(string nombreSP, List<Parametro> lstParametros)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            foreach(Parametro p in lstParametros)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }

       

    }
}
