using RecetasSLN.datos;
using RecetasSLN.presentación;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecetasSLN.servicio.implementacion;

namespace RecetasSLN
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmConsultar(new FabricaServicio()));
        }
    }
}
