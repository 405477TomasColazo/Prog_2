using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace ABMProductos
{
    public partial class frmProducto : Form
    {
        AccesoDatos oBD;
        List<Producto> productos;
        bool editando = false;

        public frmProducto()
        {
            InitializeComponent();
            oBD = new AccesoDatos();
            productos = new List<Producto>();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable dt = oBD.consultarTabla(nombreTabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        /*private void cargarLista(ListBox lista, string nombreTabla)
        {
            DataTable tabla = oBD.consultarTabla(nombreTabla);
            lista.DataSource = tabla;
            lista.ValueMember = tabla.Columns[0].ColumnName;

            tabla.Columns.Add("res", typeof(string));
            foreach (DataRow fila in tabla.Rows)
            {
                string res 
            }

        }*/
        private void cargarLista(ListBox lista, string nombreTabla)
        {
            productos.Clear();
            oBD.leerTabla(nombreTabla);
            while (oBD.Rdr.Read())
            {
                Producto oProducto = new Producto();
                if (!oBD.Rdr.IsDBNull(0))
                    oProducto.Codigo = Convert.ToInt32(oBD.Rdr["codigo"]);
                if (!oBD.Rdr.IsDBNull(1))
                    oProducto.Detalle = oBD.Rdr["detalle"].ToString();
                if (!oBD.Rdr.IsDBNull(2))
                    oProducto.Tipo = oBD.Rdr.GetInt32(2);
                if (!oBD.Rdr.IsDBNull(3))
                    oProducto.Marca = (int)oBD.Rdr[3];
                if (!oBD.Rdr.IsDBNull(4))
                    oProducto.Precio = oBD.Rdr.GetDouble(4);
                if (!oBD.Rdr.IsDBNull(5))
                    oProducto.Fecha = oBD.Rdr.GetDateTime(5);
                
                productos.Add(oProducto);
            }
            oBD.desconectar();
            lista.Items.Clear();
            for (int i = 0; i < productos.Count; i++)
            {
                lista.Items.Add(productos[i]);
            }
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            cargarCombo(cboMarca, "marcas");
            cargarLista(lstProducto, "productos");
            txtCodigo.Enabled = false;
            txtDetalle.Enabled = false;
            txtPrecio.Enabled = false;
            rbtNetBook.Enabled = false;
            rbtNoteBook.Enabled = false;
            dtpFecha.Enabled = false;
            btnCancelar.Enabled = false;
            btnGrabar.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            cboMarca.Enabled = false;
        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;
            foreach (Producto prod in productos)
            {
                if (lstProducto.SelectedItem.ToString() == prod.ToString())
                {
                    txtCodigo.Text = prod.Codigo.ToString();
                    txtDetalle.Text = prod.Detalle.ToString();
                    dtpFecha.Text = prod.Fecha.ToString();
                    txtPrecio.Text = prod.Precio.ToString();
                    cboMarca.SelectedValue = prod.Marca;
                    if(prod.Tipo == 1) { rbtNoteBook.Checked = true; }
                    else { rbtNetBook.Checked = true; }
                    break;

                }
            }
        }

        private void edicion()
        {
            txtCodigo.Enabled = !txtCodigo.Enabled;
            txtDetalle.Enabled = !txtDetalle.Enabled;
            txtPrecio.Enabled = !txtPrecio.Enabled;
            rbtNetBook.Enabled = !rbtNetBook.Enabled;
            rbtNoteBook.Enabled = !rbtNoteBook.Enabled;
            dtpFecha.Enabled = !dtpFecha.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            btnGrabar.Enabled = !btnGrabar.Enabled;
            btnEditar.Enabled = !btnEditar.Enabled;
            btnBorrar.Enabled = !btnBorrar.Enabled;
            lstProducto.Enabled = !lstProducto.Enabled;
            btnNuevo.Enabled = !btnNuevo.Enabled;
            cboMarca.Enabled = !cboMarca.Enabled;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            edicion();
            editando = true;
            MessageBox.Show($"El pk es {lstProducto.SelectedItem}");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            edicion();
            double asd;
            double.TryParse(txtPrecio.Text, out asd);
            MessageBox.Show(asd.ToString());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            edicion();
            txtCodigo.Text = null;
            txtDetalle.Text = null;
            cboMarca.Text = null;
            rbtNetBook.Checked = false;
            rbtNoteBook.Checked = false;
            dtpFecha.Text = null;
            txtPrecio.Text = null;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Producto oProducto = new Producto();
                oProducto.Codigo = int.Parse(txtCodigo.Text);
                oProducto.Detalle = txtDetalle.Text;
                oProducto.Marca = (int)cboMarca.SelectedValue;
                oProducto.Precio = double.Parse(txtPrecio.Text);
                oProducto.Fecha = dtpFecha.Value;
                if (rbtNoteBook.Checked == true) { oProducto.Tipo = 1; }
                else { oProducto.Tipo = 2; }

                string aux = $"Insert into productos values(" +
                    $"{oProducto.Codigo}, '{oProducto.Detalle}', {oProducto.Tipo}, " +
                    $"{oProducto.Marca}, {oProducto.Precio}, '{oProducto.Fecha.ToString("yyyy-MM-dd")}')";
                if (oBD.insertBD(aux) > 0)
                {
                    MessageBox.Show("Se ha cargado con exito el producto a la base de datos :)");
                    cargarLista(lstProducto, "productos");
                }
                else { MessageBox.Show("No se pudo ingresar el producto :("); }
            }
            editando = false;
        }

        private bool pkValido(int pk)
        {
            foreach (Producto prod in productos)
            {
                if(prod.Codigo == pk)
                {
                    MessageBox.Show("Ya existe un producto con ese pk.");
                    txtCodigo.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool validarDatos()
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un codigo...");
                txtCodigo.Focus();
                return false;
            }
            if (txtDetalle.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un detalle...");
                txtDetalle.Focus();
                return false;
            }
            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una marca...");
                cboMarca.Focus();
                return false;
            }
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un precio...");
                txtPrecio.Focus();
                return false;
            }
            double prex;
            if(!double.TryParse(txtPrecio.Text, out prex))
            {
                MessageBox.Show("El precio debe ser un numero...");
                txtPrecio.Focus();
                return false;
            }
            int cod;
            if(!int.TryParse(txtCodigo.Text,out cod))
            {
                MessageBox.Show("El codigo debe ser un numero entero...");
                txtCodigo.Focus();
                return false;
            }
            if (!pkValido(cod)) { return false; }
            if(rbtNetBook.Checked == false & rbtNoteBook.Checked== false)
            {
                MessageBox.Show("Debe seleccionar un tipo de dispositivo...");
                rbtNetBook.Focus();
                return false;
            }
            return true;
        }   
    }
}
