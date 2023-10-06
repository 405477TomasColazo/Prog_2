using SimulacroParcial1.Entidades;
using SimulacroParcial1.Servicios.Implementaciones;
using SimulacroParcial1.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacroParcial1.Presentacion
{
    public partial class FrmRegistrarOrdenRetiro : Form
    {
        IServicio servicio = null;
        OrdenRetiro nuevo = null;
        public FrmRegistrarOrdenRetiro(FabricaServicios fabrica)
        {
            InitializeComponent();
            nuevo = new OrdenRetiro();
            servicio = fabrica.CrearServicio();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistrarOrdenRetiro_Load(object sender, EventArgs e)
        {
            dtpFecha.Text = DateTime.Today.ToShortDateString();
            txtResponsable.Text = "Consumidor Final";
            txtCantidad.Text = "1";
            CargarMateriales();

        }

        private void CargarMateriales() 
        {
            cboMateriales.DataSource = servicio.TraerMateriales();
            cboMateriales.ValueMember = "codigo";
            cboMateriales.DisplayMember = "nombre";
        }

        private void cbMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboMateriales.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un material.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!servicio.ComprobarStock(Convert.ToInt32(txtCantidad.Text),(Material)cboMateriales.SelectedItem))
            {
                MessageBox.Show("No hay suficiente stock del producto, ingrese una cantidad inferior.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow row in dvgDetalles.Rows)
            {
                if (row.Cells["MATERIAL"].Value.ToString().Equals(cboMateriales.Text))
                {
                    MessageBox.Show("Este material ya está presupuestado.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }


            Material m = (Material)cboMateriales.SelectedItem;
            int cant = Convert.ToInt32(txtCantidad.Text);
            DetalleOrden detalle = new DetalleOrden(m, cant);

            nuevo.AgregarDetalle(detalle);
       
            dvgDetalles.Rows.Add(new object[] { m.nombre, m.stock, cant, "Quitar" });
        }

        private void dvgDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgDetalles.CurrentCell.ColumnIndex == 3) //boton Quitar de la grilla
            {
                nuevo.QuitarDetalle(dvgDetalles.CurrentRow.Index);
                dvgDetalles.Rows.RemoveAt(dvgDetalles.CurrentRow.Index);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                MessageBox.Show("Debe ingresar un Responsable", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dvgDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un detalle.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GrabarOrdenRetiro();
        }
    
        private void GrabarOrdenRetiro()
        {
            nuevo.fecha = Convert.ToDateTime(dtpFecha.Text);
            nuevo.responsable = txtResponsable.Text;
            if (servicio.GrabarOrdenRetiro(nuevo))
            {
                MessageBox.Show("Se registró con éxito la nueva orden de retiro numero: " + servicio.TraerNroNuevaOrdenRetiro(), "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("NO se pudo registrar la nueva orden de retiro. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dvgDetalles.Rows.Clear();
            nuevo.detalleOrden.Clear();
            txtResponsable.Text = string.Empty;
            txtCantidad.Text = "1";
            cboMateriales.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
