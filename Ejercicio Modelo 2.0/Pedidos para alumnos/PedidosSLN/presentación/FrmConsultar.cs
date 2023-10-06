using RecetasSLN.datos;
using RecetasSLN.dominio;
using RecetasSLN.servicios.implementaciones;
using RecetasSLN.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecetasSLN.presentación
{
    public partial class FrmConsultar : Form
    {

        IServicio servicio = null;

        public FrmConsultar(FabricaServicios f)
        {
            InitializeComponent();
            servicio = f.CrearServicio();
            
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            CargarCombo();
            cboClientes.SelectedIndex = -1;
        }

        private void CargarCombo()
        {
            cboClientes.DataSource = servicio.ObtenerClientes();
            cboClientes.ValueMember = "Id";
            cboClientes.DisplayMember = "NombreCompleto";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvPedidos.Rows.Clear();
            if(cboClientes.SelectedIndex == -1)
            {
                List<Cliente> lstClientes = servicio.ObtenerClientes();
                foreach(Cliente c in lstClientes)
                {
                    
                    foreach(Pedido p in c.Pedidos)
                    {
                        if(p.FechaEntrega >= dtpDesde.Value && p.FechaEntrega <= dtpHasta.Value) dgvPedidos.Rows.Add(new object[] { p.Codigo, c.Nombre, p.FechaEntrega, "Entregar", "Eliminar" });

                    }

                }
            }
            else
            {
                Cliente c = (Cliente)cboClientes.SelectedItem;
                foreach(Pedido p in c.Pedidos)
                {
                    if (p.FechaEntrega >= dtpDesde.Value && p.FechaEntrega <= dtpHasta.Value) dgvPedidos.Rows.Add(new object[] { p.Codigo, c.Nombre, p.FechaEntrega, "Entregar", "Eliminar" });
                }
            }
            cargarTotalPedidos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPedidos.Rows.Count && dgvPedidos.CurrentCell.ColumnIndex == 4)
            {
                DataGridViewRow filaSeleccionada = dgvPedidos.Rows[e.RowIndex];
                int codigo = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                servicio.Entregar(codigo);
            }

            if (e.RowIndex >= 0 && e.RowIndex < dgvPedidos.Rows.Count && dgvPedidos.CurrentCell.ColumnIndex == 5)
            {
                DialogResult resultado = MessageBox.Show("¿Deseas dar de baja el pedido?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DataGridViewRow filaSeleccionada = dgvPedidos.Rows[e.RowIndex];
                    int codigo = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                    servicio.Bajar(codigo);
                }
                else
                {
                    MessageBox.Show("Acción cancelada.");
                }
               
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        public void cargarTotalPedidos()
        {
            
            lblTotal.Text = "Total de pedidos: " + dgvPedidos.RowCount;
        }
    }
}
