using RecetasSLN.datos;
using RecetasSLN.datos.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecetasSLN.datos.Implementacion;
using RecetasSLN.servicio.interfaz;
using RecetasSLN.servicio.implementacion;
using RecetasSLN.dominio;

namespace RecetasSLN.presentación
{
    public partial class FrmConsultar : Form
    {
        //FabricaServicio fabrica = null;
        IServicio servicio = null;
        public FrmConsultar(FabricaServicio fabrica)
        {
            InitializeComponent();
            //this.fabrica = fabrica;
            servicio = fabrica.CrearServicio();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            CargarCombo();
        }

        private void CargarCombo()
        {
            cboClientes.DataSource = servicio.TraerClientes();
            cboClientes.ValueMember = "id";
            cboClientes.DisplayMember = "nombreCompleto";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Pedido> pedidos = servicio.TraerPedidos(Convert.ToInt32(cboClientes.ValueMember),
                Convert.ToDateTime(dtpDesde.Value.ToString("yyyyMMdd")), Convert.ToDateTime(dtpHasta.Value.ToString("yyyyMMdd")));
            foreach (Pedido p in pedidos)
            {
                dgvPedidos.Rows.Add(new object[] {  p.Codigo.ToString(),
                                                    cboClientes.DisplayMember.ToString(),
                                                    p.FechaEntrega.ToShortDateString()});
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Completar...
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
