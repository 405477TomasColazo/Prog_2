using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ABMMascotas
{
    public class AccesoDatos
    {
        private string cadenaConexion = @"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True";
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
            set { lector = value; }
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        private void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }
        public void Desconectar()
        {
            conexion.Close();
        }
        public DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable consultas = new DataTable();
            Conectar();
            comando.CommandText = $"Select * from {nombreTabla}";
            consultas.Load(comando.ExecuteReader());
            Desconectar();
            return consultas;
        }
        public void LeerTabla(string nombreTabla)
        {
            Conectar();
            comando.CommandText = $"Select * from {nombreTabla}";
            lector = comando.ExecuteReader();
        }
        public int ModificarBD(int codigo, string nombre, int especie, int sexo, DateTime nacimiento)
        {
            int filasAfectadas = 0;
            Conectar();
            comando.CommandText = "insert into mascotas values(@codigo, @nombre, @especie, @sexo, @fechaNacimiento)";
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.Parameters.AddWithValue("@especie", especie);
            comando.Parameters.AddWithValue("@sexo", sexo);
            
            comando.Parameters.AddWithValue("@fechaNacimiento", nacimiento.ToString("yyyy-MM-dd"));
            filasAfectadas = comando.ExecuteNonQuery();
            Desconectar();
            return filasAfectadas;
        }
    }
}
