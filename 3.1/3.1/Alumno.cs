using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Alumno : Persona
    {
        private int[] notas;

        public Alumno() : base()
        {
            notas = new int[3] {0,0,0};
        }
        public Alumno(string nombre, int dni, int telefono,int n1, int n2,int n3) : base(nombre, dni, telefono)
        {
            notas = new int[3] { n1, n2, n3 };
        }
        public int[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public double promedio()
        {
            return (notas[0]+notas[1]+notas[2])/3;
        }
    }
}
