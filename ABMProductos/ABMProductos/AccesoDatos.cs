using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ABMProductos
{
    public class AccesoDatos
    {
        private string cadenaCn = @"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=Informatica;Integrated Security=True";
        private SqlConnection cn;
        private SqlDataReader rdr;
        private SqlCommand cmd;

        public SqlDataReader Rdr
        {
            get { return rdr; }
            set { rdr = value; }
        }
        public AccesoDatos()
        {
            cn = new SqlConnection(cadenaCn);
        }
        private void conectar()
        {
            cn.Open();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
        }
        public void desconectar()
        {
            cn.Close();
        }
        public void leerTabla(string tabla)
        {
            conectar();
            cmd.CommandText = $"select * from {tabla}";
            rdr = cmd.ExecuteReader();
        }
        public DataTable consultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            conectar();
            cmd.CommandText = $"select * from {nombreTabla}";
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable consultarBase(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conectar();
            cmd.CommandText = consultaSQL;
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }
        public int insertBD(string consultaSQL)
        {
            int filasAfectadas = 0;
            conectar();
            cmd.CommandText = consultaSQL;
            filasAfectadas = cmd.ExecuteNonQuery();
            desconectar();
            return filasAfectadas;
        }
    }
}
