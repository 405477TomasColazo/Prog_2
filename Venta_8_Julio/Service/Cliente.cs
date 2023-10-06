using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_8_Julio.Service
{
    internal class Cliente:Persona
    {
        public int Id_cliente { get; set; }
        public Cliente(string nombre, int id_vendedor, int id_cliente):base(nombre,id_vendedor)
        {
            Id_cliente = id_cliente;
        }
        public Cliente():base()
        {
            Id_cliente=-1;
        }
    }
}
