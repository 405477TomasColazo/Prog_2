using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaCordobesaFutbol.Dominio
{
    internal class Posicion
    {
        public int IdPosicion { get; set; }
        public string Nombre { get; set; }
        public Posicion(int id,string nombre)
        {
            IdPosicion = id;
            Nombre = nombre;
        }
        public Posicion()
        {

        }
    }
}
