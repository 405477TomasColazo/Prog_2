using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaCordobesaFutbol.Dominio
{
    internal class Jugador
    {
        public int ID { get; set; }
        public Persona Persona { get; set; }
        public Equipo Equipo { get; set; }
        public Posicion Posicion { get; set; }
        public int Camiseta { get; set; }
        public Jugador(Persona persona,Equipo equipo, Posicion posicion, int camiseta)
        {
            //ID = id;
            Persona = persona;
            Equipo = equipo;
            Posicion = posicion;
            Camiseta = camiseta;
        }
        public Jugador(Persona persona, Equipo equipo)
        {
            Persona = persona;
            Equipo= equipo;
        }
        public Jugador()
        {

        }
    }
}
