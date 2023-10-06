﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialOrdenes2._0.Dato.Helper
{
    public class Parametro
    {
        public string Clave { get; set; }
        public object Valor { get; set; }

        public Parametro(string clave, object valor)
        {
            Clave = clave;
            Valor = valor;
        }
    }
}
