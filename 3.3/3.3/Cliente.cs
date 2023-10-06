using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    internal class Cliente : Persona
    {
        private string codigo;
        private int limite_credito;

        public string pCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int pLimite_credito 
        { 
            get { return limite_credito; } 
            set { limite_credito = value; } 
        }
        public Cliente() : base()
        {
            codigo = String.Empty;
            limite_credito = 0;
        }
        public Cliente(string nombre,int dni,string sexo,string codigo,int limite)
        {
            pNombre = nombre;
            limite_credito = limite;
            this.codigo = codigo;
            pDni = dni;
            pSexo = sexo;
        }
    }
}