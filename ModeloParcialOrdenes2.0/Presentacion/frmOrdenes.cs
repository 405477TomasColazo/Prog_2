using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloParcialOrdenes2._0.Servicio.Implementacion;
using ModeloParcialOrdenes2._0.Servicio.Interfaz;
using ModeloParcialOrdenes2._0.Dominio;

namespace ModeloParcialOrdenes2._0
{
    public partial class frmOrdenes : Form
    {
        IServicio servicio = null;
        OrdenRetiro oOrden = null;
        public frmOrdenes(FabricaServicio fabrica)
        {
            InitializeComponent();
            servicio=fabrica.CrearServicio();
            oOrden = new OrdenRetiro();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cboMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un material","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(txtResponsable.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un responsable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(nudStock.Value == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Material m = (Material)cboMaterial.SelectedItem;
            if(nudStock.Value > m.Stock)
            {
                MessageBox.Show($"La cantidad maximo de este material disponible para la compra es de {m.Stock}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow fila in dgvOrdenes.Rows)
            {
                if(Convert.ToInt32(fila.Cells[4].Value) == m.Codigo)
                {
                    MessageBox.Show($"Ya hay un detalle con ese material", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //dgvOrdenes.Rows.Clear();
            dgvOrdenes.Rows.Add(new object[] { m.Nombre, m.Stock, nudStock.Value, "Eliminar",m.Codigo });
            oOrden.AgregarDetalle(new DetalleOrden(m, Convert.ToInt32(nudStock.Value)));
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            txtResponsable.Text = "Consumidor Final";
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            cboMaterial.DataSource = servicio.CargarMateriales();
            cboMaterial.ValueMember = "codigo";        
            cboMaterial.DisplayMember = "nombre";
            cboMaterial.SelectedIndex = -1;
        }

        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvOrdenes.Rows.Count && e.ColumnIndex == 3)
            {
                DialogResult conf = MessageBox.Show("Seguro desea eliminar este detalle?","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (conf == DialogResult.Yes)
                {
                    oOrden.QuitarDetalle(e.RowIndex);
                    dgvOrdenes.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Seguro desea cancelar la orden?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (conf == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Seguro desea cargar esta orden?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (conf == DialogResult.Yes)
            {
                if (servicio.CargarOrden(oOrden))
                {
                    MessageBox.Show("Se cargo con exito la orden", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la orden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
