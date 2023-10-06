using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal abstract class Persona
    {
        protected string nombre;
        protected int dni;
        protected int telefono;

        public Persona()
        {
            nombre = "";
            dni = 0;
            telefono = 0;
        }
        public Persona(string nombre, int dni, int telefono)
        {
            this.nombre = nombre; this.dni = dni; this.telefono = telefono;
        }
    }
}
