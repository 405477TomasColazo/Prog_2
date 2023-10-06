using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_pastelitos
{
    public class Vendedor:Persona
    {
        private int patrulla;

        public int Patrulla
        {
            get { return patrulla; }
            set { patrulla = value; }
        }
        public Vendedor(): base()
        {
            patrulla = 0;
        }
        public Vendedor(int id, string nombre, int patrulla): base(id,nombre)
        {
            Patrulla = patrulla;
        }
    }
}
