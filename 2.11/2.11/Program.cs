using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mazo mazo = new Mazo();
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("\nPresiones una de las siguientes teclas para continuar:\n" +
                    "A) Para barajar.\n" +
                    "S) Para ver la siguiente carta.\n" +
                    "D) Para ver todas las cartas restantes en orden que quedan en el maso.\n" +
                    "Z) Para pedir cartas\n" +
                    "X) Para ver las cartas retiradas del mazo hasta ahora\n" +
                    "C) Para saber cuantas cartas quedan en el mazo.\n" +
                    "Presione ESCAPE para salir del menu\n");
                ConsoleKey tecla = Console.ReadKey().Key;
                switch (tecla)
                {
                    case ConsoleKey.Escape:
                        menu = false;
                        break;
                    case ConsoleKey.A:
                        mazo.barajar();
                        Console.WriteLine("\nBarajando...");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("\nLa siguiente carta en salir es " + mazo.siguienteCarta());
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("\nEl orden actual del mazo es:\n");
                        mazo.mostrarBaraja();
                        break;
                    case ConsoleKey.Z:
                        Console.WriteLine("Cuantas cartas desea sacar?\n");
                        Console.WriteLine(mazo.darCartas(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine(mazo.cartasMonton());
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine(String.Format("\nEn el mazo quedan {0} cartas disponibles.",mazo.cartasDisponibles()));
                        break;
                }
            }
        }
    }
}
