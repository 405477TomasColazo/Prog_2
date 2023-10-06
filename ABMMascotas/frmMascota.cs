using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//CURSO – LEGAJO – APELLIDO – NOMBRE

namespace ABMMascotas
{
    public partial class frmMascota : Form
    {
        AccesoDatos oBD;
        List<Mascota> listaMascotas;

        public frmMascota()
        {
            InitializeComponent();
            oBD = new AccesoDatos();
            listaMascotas = new List<Mascota>();
        }

        private void frmMascota_Load(object sender, EventArgs e)
        {
            Habilitar();
            CargarLista(lstMascotas,"mascotas");
            CargarCombo(cboEspecie);
        }

        private void Habilitar()
        {
            txtCodigo.Enabled = !txtCodigo.Enabled;
            txtNombre.Enabled = !txtNombre.Enabled;
            cboEspecie.Enabled = !cboEspecie.Enabled;
            rbtHembra.Enabled = !rbtHembra.Enabled;
            rbtMacho.Enabled = !rbtMacho.Enabled;
            dtpFechaNacimiento.Enabled = !dtpFechaNacimiento.Enabled;
            lstMascotas.Enabled = !lstMascotas.Enabled;
        }

        private void CargarCombo(ComboBox combo)
        {
            DataTable dt = oBD.ConsultarTabla("especies");
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle  = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
            
        }

        private void CargarLista(ListBox lst, string nombreTabla)
        {
            listaMascotas.Clear();
            lst.Items.Clear();
            DataTable dt = oBD.ConsultarTabla(nombreTabla);
            foreach (DataRow fila in dt.Rows)
            {
                Mascota m = new Mascota();
                m.Codigo = Convert.ToInt32(fila[0]);
                m.Nombre = fila[1].ToString();
                m.Especie = Convert.ToInt32(fila[2]);
                m.Sexo = Convert.ToInt32(fila[3]);
                m.FechaNacimiento = Convert.ToDateTime(fila[4]);
                listaMascotas.Add(m);
            }
            lst.DataSource = listaMascotas;
            
            /*oBD.LeerTabla(nombreTabla);
            while (oBD.Lector.Read())
            {
                Mascota oMascota = new Mascota();
                if (!oBD.Lector.IsDBNull(0))
                {
                    oMascota.Codigo = oBD.Lector.GetInt32(0);
                }
                if (!oBD.Lector.IsDBNull(1))
                {
                    oMascota.Nombre = oBD.Lector.GetString(1);
                }
                if(!oBD.Lector.IsDBNull(2))
                {
                    oMascota.Especie = oBD.Lector.GetInt32(2);
                }
                if (!oBD.Lector.IsDBNull(3))
                {
                    oMascota.Sexo = oBD.Lector.GetInt32(3);
                }
                if (!oBD.Lector.IsDBNull(4))
                {
                    oMascota.FechaNacimiento = oBD.Lector.GetDateTime(4);
                }
                listaMascotas.Add(oMascota);
            }
            oBD.Desconectar();
            lst.Items.Clear();
            foreach (Mascota mascota in listaMascotas)
            {
                lst.Items.Add(mascota);
            }*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
               Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar();
            btnGrabar.Enabled = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Mascota oMascota = new Mascota();
                oMascota.Codigo = int.Parse(txtCodigo.Text);
                oMascota.Nombre = txtNombre.Text;
                oMascota.Especie = (int)cboEspecie.SelectedValue;
                if(rbtMacho.Checked == true) { oMascota.Sexo = 1; }
                else { oMascota.Sexo = 2; }
                oMascota.FechaNacimiento = dtpFechaNacimiento.Value;
                if (oBD.ModificarBD(oMascota.Codigo, oMascota.Nombre, oMascota.Especie, oMascota.Sexo, oMascota.FechaNacimiento) > 0)
                {
                    MessageBox.Show("Se ha cargado con exito la mascota a la base de datos");
                    CargarLista(lstMascotas, "mascotas");
                    Habilitar();
                    btnGrabar.Enabled = false;
                }
            }
            //valida datos...
               //crear objeto
  
                    //insert usando parámetros
        }

        private bool Validar()
        {
            if (txtCodigo.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un codigo...");
                txtCodigo.Focus();
                return false;
            }
            if(txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un nombre...");
                txtNombre.Focus();
                return false;
            }
            if(cboEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una especie...");
                cboEspecie.Focus();
                return false;
            }
            if(rbtHembra.Checked==false & rbtMacho.Checked == false)
            {
                MessageBox.Show("Seleccione un sexo");
                rbtHembra.Focus();
                return false;
            }
            int cod;
            if(!int.TryParse(txtCodigo.Text, out cod))
            {
                MessageBox.Show("El codigo debe ser numerico...");
                txtCodigo.Focus();
                return false;
            }
            if (!pkValido(cod))
            {
                MessageBox.Show("Ya existe un animal con ese codigo...");
                txtCodigo.Focus();
                return false;
            }
            return true;
        }

        private bool pkValido(int pk)
        {
            foreach (Mascota mascota in listaMascotas)
            {
                if(pk == mascota.Codigo)
                {
                    return false;
                }
            }
            return true;
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Mascota mascota in listaMascotas)
            {
                if(mascota.ToString() == lstMascotas.SelectedItem.ToString())
                {
                    txtCodigo.Text = mascota.Codigo.ToString();
                    txtNombre.Text = mascota.Nombre;
                    cboEspecie.SelectedValue = mascota.Especie;
                    dtpFechaNacimiento.Value = mascota.FechaNacimiento;
                    if(mascota.Sexo == 1) { rbtMacho.Checked = true; }
                    else { rbtHembra.Checked = true; }
                    break;
                }
            }
     
        }

        private void frmMascota_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro de abandonar la aplicación?", "SALIENDO"
                                , MessageBoxButtons.YesNo, MessageBoxIcon.Question
                                , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
