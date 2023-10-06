using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1.Entidades
{
    public class Material
    {
        public int codigo {  get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }

        public Material() 
        {
            this.codigo = 0;
            this.nombre = string.Empty;
            this.stock = 0;

        }

        public Material(int codigo, string nombre, int stock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.stock = stock;
        }
    }
}
