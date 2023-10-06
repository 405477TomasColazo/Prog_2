using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaCordobesaFutbol.Dominio
{
    internal class Persona
    {
        public int Dni { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNac { get; set; }
        public Persona(int dni)
        {
            Dni = dni;
            NombreCompleto = string.Empty;
            FechaNac = DateTime.Now;
        }
        public Persona(int dni, string nombre, DateTime nac)
        {
            Dni = dni;
            NombreCompleto = nombre;
            FechaNac = nac;
        }
        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
