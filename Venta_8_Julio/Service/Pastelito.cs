using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_8_Julio.Service
{
    internal class Pastelito
    {
        public int Id_Pastelito { get; set; }
        public int Sabor { get; set; }
        public float Stock { get; set; }
        public float Precio_Venta_Doc { get; set; }
        public float Costo_Doc { get; set; }
        public float Producidos { get; set; }
    }
}
