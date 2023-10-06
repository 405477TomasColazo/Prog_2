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

namespace test_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-UUMMIAU\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand($"insert into info(data1,data2) values('{tbx_data1.Text}','{tbx_data2.Text}')",cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
