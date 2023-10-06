using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    public class Persona
    {
        private int edad;
        private string nombre;
        private string sexo;
        private double altura;
        private double peso;
        private int dni;

        public Persona()
        {
            nombre = "";
            sexo = "H";
            altura = peso = dni = edad = 0;
        }
        public Persona(string nombre, int edad, string sexo, double altura,double peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.altura = altura;    
            this.peso = peso;
        }
        public int pEdad
        { get { return this.edad; } set { edad = value; } }
        public string pNombre
        { get { return this.nombre; } set { nombre = value; } }
        public string pSexo
        { get { return this.sexo; } set { sexo = value; } }
        public double pAltura
        { get { return this.altura; } set { altura = value; } }
        public double pPeso
        { get { return this.peso; } set { peso = value; } }
        public int pDni 
        { get { return this.dni; } set { dni = value; } }
        /*public int calcularIMC()
        {
            double aux = peso / Math.Pow(altura,2);
            if (aux < 20){
                return -1;
            }
            if (20 <= aux & aux <= 25)s
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public bool esMayorDeEdad()
        {
            return edad >= 18;
        }*/
    }
}
