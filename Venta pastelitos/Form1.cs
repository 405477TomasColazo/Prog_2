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

namespace Venta_pastelitos
{
    public partial class Form1 : Form
    {
        AccesoDatos oBD;
        List<Vendedor> vendedores;
        public Form1()
        {
            InitializeComponent();
            oBD = new AccesoDatos();
            vendedores = new List<Vendedor>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbox_Vendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbox_Vendedores_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarLista(lbox_Vendedores, "vendedores");
        }

        private void CargarLista(ListBox lista, string tabla)
        {
            DataTable dt = oBD.ConsultarTabla(tabla);
            lista.DataSource = dt;
            lista.ValueMember = dt.Columns[0].ColumnName;
            lista.DisplayMember = dt.Columns[1].ColumnName;

        }
    }
}
