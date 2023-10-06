using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp
{
    public class Jugador :Persona
    {
        private string posicion;

        private bool estaLesionado;

        private int faltas;
        public int Faltas
        {
            get { return faltas; }
            set { faltas = value; }
        }

        public bool EstaLesionado
        {
            get { return estaLesionado; }
            set { estaLesionado = value; }
        }

        public string Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        public Jugador() : base()
        {
            estaLesionado = false;
            faltas = 0;
            posicion = "Sin definir";
        }
        public Jugador(string nombre, int clase, string grupo_sang, string posicion,bool lesion, int faltas): base()
        {
            NombreCompleto = nombre;
            Clase = clase;
            GrupoSanguineo = grupo_sang;
            Posicion = posicion;
            estaLesionado = lesion;
            this.faltas = faltas;
        }
        public override string ToString()
        {
            string lesionado = estaLesionado ? "SI" : "NO";
            return base.ToString() + " | Juega de: " + posicion + " | Faltas(" + faltas + ")";
        }

        public override int Valoracion()
        {
            return (faltas == 0 && !estaLesionado) ? 10 : 5;
        }
    }
}
