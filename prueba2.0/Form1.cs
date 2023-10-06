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

namespace prueba2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=dbPastelitos;Integrated Security=True"))
            {
                cn.Open();
                string vend = "SELECT nombre FROM vendedores";
                SqlCommand cmd = new SqlCommand(vend, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                lbox_Vendedores.Items.Clear();
                HashSet<string> valoresUnicos = new HashSet<string>();
                while (dr.Read())
                {
                    string valor = dr.GetString(0);
                    valoresUnicos.Add(valor);
                }
                dr.Close();
                foreach (string valorUnico in valoresUnicos)
                {
                    lbox_Vendedores.Items.Add(valorUnico);
                }
                cn.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
