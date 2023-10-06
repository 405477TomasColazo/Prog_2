using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_pastelitos
{
    public abstract class Persona
    {
        private string nombre;

        public string  Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Persona()
        {
            id = 0;
            nombre = string.Empty;
        }
        public Persona(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
