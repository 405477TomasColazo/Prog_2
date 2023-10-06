using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_8_Julio.Service
{
    public class Vendedor:Persona
    {
        public int Id_patrulla { get; set; }
        public string Apellido { get; set; }
        public Vendedor():base()
        {
            Id_patrulla = -1;
            Apellido = "";
        }
        public Vendedor(string nombre, int id_vendedor, int patrulla, string apellido) : base(nombre,id_vendedor)
        {
            Id_patrulla = patrulla;
            Apellido = apellido;
        }
    }
}
