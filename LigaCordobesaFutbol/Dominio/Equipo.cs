using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaCordobesaFutbol.Dominio
{
    internal class Equipo
    {
        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public Persona DirectorTecnico { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public Equipo()
        {
            IdEquipo = -1;
            Nombre = string.Empty;
        }
        public Equipo(int id, string nombre, Persona dt)
        {
            IdEquipo=id;
            Nombre = nombre;
            DirectorTecnico = dt;
        }
    }
}
