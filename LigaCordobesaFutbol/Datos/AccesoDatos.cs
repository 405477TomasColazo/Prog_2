using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LigaCordobesaFutbol.Datos
{
    
    internal class AccesoDatos
    {
        private string cadenaConexion = @"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=LigaCordobesaFutbol;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando;
        SqlParameter parametro;
        public AccesoDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        private void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;           
        }
        private void Desconectar()
        {
            conexion.Close();
        }
        public DataTable ConsultarBD(string SP, string param)
        {
            DataTable dt = new DataTable();
            comando.CommandText = SP;
            parametro = new SqlParameter();
            parametro.ParameterName = param;
            parametro.SqlDbType = SqlDbType.NVarChar;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            dt.Load(comando.ExecuteReader());
            Desconectar();
            return dt;
        }
    }
}
