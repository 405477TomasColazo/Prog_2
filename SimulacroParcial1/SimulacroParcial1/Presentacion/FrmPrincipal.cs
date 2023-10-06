using SimulacroParcial1.Servicios.Implementaciones;
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
    public partial class FrmPrincipal : Form
    {
        FabricaServicios fabrica = null;

        public FrmPrincipal(FabricaServicios fabrica)
        {
            InitializeComponent();
            this.fabrica= fabrica;
        }



        private void nuevaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarOrdenRetiro ordenRetiro = new FrmRegistrarOrdenRetiro(fabrica);
            ordenRetiro.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ordenDeRetiroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
