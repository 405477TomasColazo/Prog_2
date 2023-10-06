using RecetasSLN.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecetasSLN.servicio.implementacion;
using RecetasSLN.servicio.interfaz;
using RecetasSLN.dominio;

namespace RecetasSLN.presentación
{
    public partial class FrmConsultar : Form
    {
        IServicio servicio = null;
        public FrmConsultar(FabricaServicio fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            CargarCombo();
            CargarTotalPedidos();
            cboClientes.SelectedIndex = -1;
        }

        private void CargarCombo()
        {
            cboClientes.DataSource = servicio.TraerClientes();
            cboClientes.ValueMember = "Id";
            cboClientes.DisplayMember = "NombreCompleto";
        }
        private void CargarTotalPedidos()
        {
            lblTotal.Text = "Total de pedidos: " + dgvPedidos.Rows.Count;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvPedidos.Rows.Clear();
            if(cboClientes.SelectedIndex == -1)
            {
                List<Cliente> clientes = servicio.TraerClientes();
                foreach (Cliente c in clientes)
                {
                    foreach (Pedido p in c.Pedidos)
                    {
                        if(p.FechaEntrega>= dtpDesde.Value && p.FechaEntrega <= dtpHasta.Value)
                        {
                            dgvPedidos.Rows.Add(new object[] {p.Codigo,c.NombreCompleto,p.FechaEntrega,"Entregar","Eliminar"});
                        }
                    }
                }
            }
            else
            {
                //Cliente c = (Cliente)cboClientes.SelectedItem;
                foreach (Pedido p in ((Cliente)cboClientes.SelectedItem).Pedidos)
                {
                    if (p.FechaEntrega >= dtpDesde.Value && p.FechaEntrega <= dtpHasta.Value)
                    {
                        dgvPedidos.Rows.Add(new object[] { p.Codigo, ((Cliente)cboClientes.SelectedItem).NombreCompleto, p.FechaEntrega, "Entregar", "Eliminar" });
                    }
                }
            }
            CargarTotalPedidos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("¿Desea salir de la aplicacion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(conf == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgvPedidos.RowCount && e.ColumnIndex == 4)
            {
                servicio.EntregarPedido(Convert.ToInt32(dgvPedidos[0, e.RowIndex].Value));
            }
            else if (e.RowIndex >= 0 && e.RowIndex < dgvPedidos.RowCount && e.ColumnIndex == 5)
            {
                DialogResult conf = MessageBox.Show("¿Desea dar de baja el pedido?", "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conf == DialogResult.Yes)
                {
                    servicio.DarBaja(Convert.ToInt32(dgvPedidos[0, e.RowIndex].Value));
                }
                else
                {
                    MessageBox.Show("Accion cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                    
            }
        }
    }
}
