using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    public class Password
    {
        private int longitud;
        private string valor;
        Password()
        {
            longitud = 8;
        }
        Password(string valor)
        {
            this.valor = valor;

        }
        public int pLongitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        public string vpValor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
