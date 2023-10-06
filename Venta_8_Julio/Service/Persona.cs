using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_8_Julio.Service
{
    public abstract class Persona
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int id_Vendedor;
        public int Id_Vendedor
        { 
            get { return id_Vendedor; } 
            set { id_Vendedor = value;} 
        }
        public Persona()
        {
            nombre = string.Empty;
            id_Vendedor = -1;
        }
        protected Persona(string nombre, int id_vendedor)
        {
            this.nombre = nombre;
            this.id_Vendedor = id_vendedor;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
