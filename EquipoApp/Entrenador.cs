using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp
{
    internal class Entrenador: Persona
    {
        private int antiguedad;
        public int pAntiguedad
        {
            get { return antiguedad; }
            set { antiguedad = value; }
        }
        private int cargo;

        public int pCargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public Entrenador():base()
        {
            antiguedad = 1;
            cargo = 1;
        }
        public Entrenador(int clase, string nombre,string grup_sang,int antiguedad,int cargo):base()
        {
            Clase = clase;
            NombreCompleto = nombre;
            GrupoSanguineo = grup_sang;
            this.antiguedad=antiguedad;
            this.cargo=cargo;
        }
        public override int Valoracion()
        {
            if (antiguedad <= 5) { return 5; }
            else { return antiguedad; }
        }
        public override string ToString()
        {
            string aux = "";
            if(cargo == 0) { aux = "Director tecnico"; }
            else if (cargo == 1) { aux = "Preparador fisico"; }
            else { aux ="Ayudante de campo"; }
            return $"Entrenador: {NombreCompleto} | Clase: [{Clase}] | Grupo sanguineo: {GrupoSanguineo} | Cargo: {aux} | Antiguedad: {antiguedad} años"; 
        }
    }
}   
