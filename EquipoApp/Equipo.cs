using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp
{
    public class Equipo
    {
        private string categoria;
        private Persona[] personas;
        private int siguiente;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public Equipo(int total)
        {
            categoria = "S/D";
            personas = new Persona[total];
            siguiente = 0;
        }

        public void AgregarPersona(Persona persona)
        {
            if (siguiente < personas.Length)
            {
                personas[siguiente] = persona;
                siguiente++;
            }

            //ListarIntegrantes();
        }

        //Completar:


        /// <summary>
        /// Permite retornar una cadena con el listado completo de todos los integrantes de un equipo, 
        /// tanto jugadores como entrenadores.
        /// </summary>
               
        public string ListarIntegrantes()
        {
            string aux = "";
            foreach (Persona persona in personas)
            {
                aux += persona.ToString() +"\n";
            }
            return aux;
        }


        /// <summary>
        /// Permite retornar un valor entero correspondiente a la cantidad de jugadores cuya posición y valoración  
        /// se reciben como parámetros
        /// </summary>
        /// <param name="posicion">Posición del jugador</param>
        /// <param name="valor">Indicador de valoración del jugador</param>
        /// <returns>Cantidad de jugadores de la posición recibida con una valoración igual o superior al segundo parámetro</returns>

        public int JugadoresConPosicionValorados(string posicion, int valor)
        {
            int aux = 0;
            foreach (Jugador jugador in personas.Where(x => x is Jugador))
            {
                if (jugador.Posicion == posicion && jugador.Valoracion() == valor) { aux++; }
            }
            return aux;
        }

    }
}
