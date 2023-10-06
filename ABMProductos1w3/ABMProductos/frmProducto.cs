using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABMProductos
{
    public partial class frmProducto : Form
    {
        AccesoDatos oBD;                //objeto instancia de la Clase delegada para manejo de la BD
        List<Producto> listaProductos;  //lista dinamica para n objetos Producto

        public frmProducto()
        {
            InitializeComponent();
            oBD=new AccesoDatos();
            listaProductos=new List<Producto>();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            CargarCombo(cboMarca, "marcas");
            CargarLista(lstProducto, "productos");
        }

        private void CargarLista(ListBox lista, string nombreTabla) //usando DataReader conectado
        {
            listaProductos.Clear();
            //traer  datos de BD
            oBD.LeerTabla(nombreTabla);
            while (oBD.Lector.Read())
            {
                //cargar lista de objetos
                Producto oProducto = new Producto();
                if (!oBD.Lector.IsDBNull(0))
                    oProducto.Codigo = Convert.ToInt32(oBD.Lector["codigo"]);
                if (!oBD.Lector.IsDBNull(1))
                    oProducto.Detalle = oBD.Lector["detalle"].ToString();
                if (!oBD.Lector.IsDBNull(2))
                    oProducto.Tipo = oBD.Lector.GetInt32(2);
                if (!oBD.Lector.IsDBNull(3))
                    oProducto.Marca = (int)oBD.Lector[3];
                if (!oBD.Lector.IsDBNull(4))
                    oProducto.Precio = oBD.Lector.GetDouble(4);
                if (!oBD.Lector.IsDBNull(5))
                    oProducto.Fecha = oBD.Lector.GetDateTime(5);

                listaProductos.Add(oProducto);
            }
            oBD.Desconectar();

            //mostrar en listbox
            lista.Items.Clear();
            //lista.DataSource=listaProductos;      //agrega la coleccion completa a la ListBox
            for (int i = 0; i < listaProductos.Count; i++)
            {
                lista.Items.Add(listaProductos[i]);
            }
        }

        private void CargarCombo(ComboBox combo, string nombreTabla)
        {
           // DataTable tabla = oBD.ConsultarBD("SELECT * FROM " + nombreTabla + " ORDER BY 2");
            DataTable tabla = oBD.ConsultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;    //"idMarca"
            combo.DisplayMember = tabla.Columns[1].ColumnName;  //"nombreMarca"
            combo.DropDownStyle = ComboBoxStyle.DropDownList;   //no permite edición, solo selección
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //validar datos
            if (ValidarDatos())
            {
                //crear objeto
                Producto oProducto = new Producto();
                oProducto.Codigo = Convert.ToInt32(txtCodigo.Text);
                oProducto.Detalle=txtDetalle.Text;
                oProducto.Marca = (int)cboMarca.SelectedValue;
                if (rbtNoteBook.Checked)
                    oProducto.Tipo = 1;
                else
                    oProducto.Tipo = 2;
                oProducto.Precio= Convert.ToDouble(txtPrecio.Text);
                oProducto.Fecha = dtpFecha.Value;

                //validar no exista PK si no es identity
                if (!Existe(oProducto.Codigo))
                {
                    //insert 

                    string consulta = "INSERT INTO Productos VALUES (" +
                        oProducto.Codigo + ",'" +
                        oProducto.Detalle + "'," +
                        oProducto.Tipo + "," +
                        oProducto.Marca + "," +
                        oProducto.Precio + ",'" +
                        oProducto.Fecha.ToString("yyyy-MM-dd") + "')";

                    if (oBD.ActualizarBD(consulta) > 0)
                    {
                        MessageBox.Show("Se insertó con éxito el nuevo producto!!!");
                        CargarLista(lstProducto, "productos");
                    }
                    else

                        MessageBox.Show("No se pudo insertar el nuevo producto!!!");
                }
            }
        }

        private bool Existe(int pk)
        {
            bool encontro = false;
            //foreach (Producto p in listaProductos)
            //{
            //    if (p.Codigo == pk)
            //        encontro = true;
            //}
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Codigo == pk)
                    encontro = true;
            }
            return encontro;
        }

        private bool ValidarDatos()
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
            // validar campos vacios 
            // validar campos numericos
            // validar campos fecha

            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
