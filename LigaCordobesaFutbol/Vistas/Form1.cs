using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LigaCordobesaFutbol.Dominio;

namespace LigaCordobesaFutbol
{
    public partial class frmRegistroEquipos : Form
    {
        Equipo equipo;
        int cont;
        List<Jugador> listJugadores;
        List<Posicion> listPosiciones;
        public frmRegistroEquipos()
        {
            InitializeComponent();
            equipo = new Equipo();
            listJugadores = new List<Jugador>();
            listPosiciones = new List<Posicion>();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                dgvJugadores.Rows.RemoveAt(e.RowIndex);
                cont -= 1;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboJugador.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un jugador...",
                                "Control",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            if(string.IsNullOrEmpty(txtNro.Text) || !int.TryParse(txtNro.Text, out _))
            {
                MessageBox.Show("Debe ingresar un numero de camisa valido valida...",
                                                "Control",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow fila in dgvJugadores.Rows)
            {
                if (fila.Cells["colNombre"].Value.ToString().Equals(cboJugador.Text))
                {
                    MessageBox.Show("Este jugador ya esta en el equipo...",
                                "Control",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);    
                    return;
                }
            }
            DataRowView item = (DataRowView)cboJugador.SelectedItem;
            int dni = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            DateTime fecha = Convert.ToDateTime(item.Row.ItemArray[2]);
            Persona p = new Persona(dni, nom, fecha);
            Posicion pos = new Posicion();
            foreach (Posicion posicion in listPosiciones)
            {
                if(posicion.Nombre == cboPosicion.Text)
                {
                    pos = posicion;
                }
            }
            Jugador j = new Jugador(p,equipo,pos,Convert.ToInt32(txtNro.Text));
            listJugadores.Add(j);
            cont += 1;
            //dgvJugadores.Rows.Add(cont, p.NombreCompleto, "", p.Dni, p.FechaNac.ToShortDateString(), "Quitar");
            dgvJugadores.Rows.Add();
            dgvJugadores.Rows[cont - 1].Cells[0].Value = cont;
            dgvJugadores.Rows[cont - 1].Cells[1].Value = p.NombreCompleto;
            dgvJugadores.Rows[cont - 1].Cells[2].Value = txtNro.Text;
            dgvJugadores.Rows[cont - 1].Cells[3].Value = cboPosicion.Text;
            dgvJugadores.Rows[cont - 1].Cells[4].Value = p.Dni;
            dgvJugadores.Rows[cont - 1].Cells[5].Value = p.FechaNac.ToShortDateString();
            dgvJugadores.Rows[cont - 1].Cells[6].Value = "Quitar";
        }

        private void CargarPosiciones()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=LigaCordobesaFutbol;Integrated Security=True";
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_POSICIONES";
            dt.Load(cmd.ExecuteReader());
            conexion.Close();
            cboPosicion.DataSource = dt;
            cboPosicion.ValueMember = "iDposicion";
            cboPosicion.DisplayMember = "nombre";
            foreach (DataRow fila in dt.Rows)
            {
                Posicion p = new Posicion(Convert.ToInt32(fila[0].ToString()), fila[1].ToString());
                listPosiciones.Add(p);
            }
        }

        private void frmRegistroEquipos_Load(object sender, EventArgs e)
        {
            CargarJugadores();
            CargarPosiciones();
        }

        private void CargarJugadores()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=LigaCordobesaFutbol;Integrated Security=True";
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PERSONAS";
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();
            cboJugador.DataSource = tabla;
            cboJugador.ValueMember = "dni";
            cboJugador.DisplayMember = "nombreCompleto";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Validar();
            equipo.Nombre = txtNombre.Text;
            Persona dt = new Persona(1, txtDT.Text, DateTime.Today);
            equipo.DirectorTecnico = dt;
            foreach (Jugador j in listJugadores)
            {
                equipo.Jugadores.Add(j);
            }
            GuardarEquipo();
            GuardarJugadores();
        }

        private void GuardarJugadores()
        {
            int ultimo = Ulitimo();
            foreach (Jugador j in listJugadores)
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = @"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=LigaCordobesaFutbol;Integrated Security=True";
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_JUGADOR";
                cmd.Parameters.Add("@persona", SqlDbType.Int).Value = j.Persona.Dni;
                cmd.Parameters.Add("@equipo", SqlDbType.Int).Value = ultimo;
                cmd.Parameters.Add("@camiseta",SqlDbType.Int).Value = j.Camiseta;
                cmd.Parameters.Add("@posicion", SqlDbType.Int).Value = j.Posicion.IdPosicion;
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        private int Ulitimo()
        {

                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = @"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=LigaCordobesaFutbol;Integrated Security=True";
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_ULTIMO";
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@last";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);
                comando.ExecuteNonQuery();
                conexion.Close();
            return Convert.ToInt32(parametro.Value.ToString());

        }

        private void GuardarEquipo()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=LigaCordobesaFutbol;Integrated Security=True";
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_EQUIPO";
            cmd.Parameters.Add("@nombre",SqlDbType.VarChar, 40).Value=equipo.Nombre;
            cmd.Parameters.Add("@dt",SqlDbType.Int).Value = equipo.DirectorTecnico.Dni;
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void Validar()
        {
            if (txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre de equipo...",
                                                "Control",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                return;
            }
            if (txtDT.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre del director tecnico...",
                                                "Control",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
