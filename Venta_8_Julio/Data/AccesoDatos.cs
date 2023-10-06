using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Venta_8_Julio.Data
{
    public class AccesoDatos
    {
        private string cadenaConexion = @"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=PastelitosJulio;Integrated Security=True";
        private SqlConnection conexion;
        private SqlCommand comando;

        public AccesoDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        private void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        private void Desconectar()
        {
            conexion.Close();
        }
        public DataTable ConsultarBD(string consultaSQL)
        {
            DataTable dt = new DataTable();
            Conectar();
            comando.CommandText = consultaSQL;
            dt.Load(comando.ExecuteReader());
            Desconectar();
            return dt;
        }
        public int ModificarBD(string sentenciaSQL, List<Parametro> parametros)
        {
            int filas_Afectadas = 0;
            Conectar();
            comando.CommandText= sentenciaSQL;
            comando.Parameters.Clear();
            foreach (Parametro p in parametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            filas_Afectadas = comando.ExecuteNonQuery();
            Desconectar();
            return filas_Afectadas;
        }
    }
}
