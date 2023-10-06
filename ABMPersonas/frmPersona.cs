using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABMPersonas
{
    public partial class frmPersona : Form
    {
        bool esNuevo = false;

        public frmPersona()
        {
            InitializeComponent();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            Habilitar(false);
            CargarCombo("tipo_documento", cboTipoDocumento);
            CargarCombo("estado_civil", cboEstadoCivil);
            CargarLista("personas", lstPersonas);

        }

        private void CargarLista(string tabla, ListBox lst)
        {
            string cnnString = @"Data Source =.\SQLEXPRESS; Initial Catalog = TUPPI; Integrated Security = True";
            //SqlConnection cnn = new SqlConnection(cnnString);
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = cnnString;
            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM " + tabla;
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;

            
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nom = reader["nombres"].ToString();
                string ape = reader["apellido"].ToString();
                int tipodoc = Convert.ToInt32(reader["tipo_documento"].ToString());
                int doc = Convert.ToInt32(reader["documento"].ToString());
                int sexo = Convert.ToInt32(reader["sexo"].ToString());
                int estadoCivil = Convert.ToInt32(reader["estado_civil"].ToString());
                bool esFallecio = bool.Parse(reader["fallecio"].ToString());
                DateTime fec = Convert.ToDateTime(reader["fecha_nacimiento"].ToString());
                
                Persona oPersona = new Persona(nom,ape,tipodoc,doc,sexo,estadoCivil,esFallecio,fec);
                lst.Items.Add(oPersona);
            }



            cnn.Close();
        }

        private void CargarCombo(string tabla, ComboBox cbo)
        {
            string cnnString = @"Data Source =.\SQLEXPRESS; Initial Catalog = TUPPI; Integrated Security = True";
            //SqlConnection cnn = new SqlConnection(cnnString);
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = cnnString;
            cnn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM " + tabla;
                cmd.Connection= cnn;
                cmd.CommandType = CommandType.Text;

                DataTable dt = new DataTable();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);


                cbo.DataSource = dt;
                cbo.DisplayMember = dt.Columns[1].ColumnName;
                cbo.ValueMember = dt.Columns[0].ColumnName;
            

            cnn.Close();

        }

        

        private void Habilitar(bool x)
        {
            txtApellido.Enabled = x;
            txtNombres.Enabled = x;
            cboTipoDocumento.Enabled = x;
            txtDocumento.Enabled = x;
            cboEstadoCivil.Enabled = x;
            dtpFechaNacimiento.Enabled = x;
            rbtFemenino.Enabled = x;
            rbtMasculino.Enabled = x;
            chkFallecio.Enabled = x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            lstPersonas.Enabled = !x;
        }

        private void limpiar()
        {
            txtApellido.Text = "";
            txtNombres.Text = "";
            cboTipoDocumento.SelectedIndex = -1;
            txtDocumento.Text = "";
            cboEstadoCivil.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Today;
            rbtFemenino.Checked = false;
            rbtMasculino.Checked = false;
            chkFallecio.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Habilitar(true);
            limpiar();
            txtApellido.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            txtDocumento.Enabled = false;
            txtApellido.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            limpiar();
            Habilitar(false);
            esNuevo = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {


            if (esNuevo)
            {

                // VALIDAR QUE NO EXISTA LA PK !!!!!! (SI NO ES AUTOINCREMENTAL / IDENTITY)

                // insert con sentencia SQL tradicional

                // insert usando parámetros


                Habilitar(false);
                esNuevo = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

    }
}
