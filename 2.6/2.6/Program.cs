using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            Console.WriteLine("Cuantos litros de combustible desea cargar?");
            auto1.CargarCombustible(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Cuantos kilometros desea recorrer?");
            auto1.Conducir(Convert.ToDouble(Console.ReadLine()));

            Console.ReadLine();
        }
    }
}
