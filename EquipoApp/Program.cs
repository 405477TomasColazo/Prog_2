using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas personas componen al equipo?\n");
            int cant = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCual es la categoria del equipo?\n");
            string cat = Console.ReadLine();
            Equipo equipo = new Equipo(cant);
            equipo.Categoria = cat;

            for (int i = 0; i < cant; i++)
            {
                ConsoleKey a = ConsoleKey.A;
                while (a != ConsoleKey.D1 && a != ConsoleKey.NumPad1 && a != ConsoleKey.D2 && a != ConsoleKey.NumPad2)
                {
                    Console.WriteLine("\nJugador o entrenador?\n1) Entrenador\n2) Jugador\n");
                    a = Console.ReadKey().Key;
                }
                if (a == ConsoleKey.D1 || a == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("Ingrese nombre del entrenador\n");
                    string nombre = Console.ReadLine();
                    Console.WriteLine($"\nIngrese clase de {nombre}\n");
                    int clase = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nIngrese grupo sanguineo de {nombre}\n");
                    string sang = Console.ReadLine();
                    Console.WriteLine($"\nIngrese la antiguedad de {nombre} desempeñando su cargo\n");
                    int antig = int.Parse(Console.ReadLine());
                    ConsoleKey carg = ConsoleKey.D;
                    while(carg != ConsoleKey.A && carg != ConsoleKey.B && carg != ConsoleKey.C)
                    {
                        Console.WriteLine($"\nSeleccione el cargo q desempeña {nombre}\n"+
                            "A) Director tecnico\n" +
                            "B) Preparador fisico\n" +
                            "C) Ayudante de campo\n");
                        carg = Console.ReadKey().Key;
                    }
                    if (carg == ConsoleKey.A) { equipo.AgregarPersona(new Entrenador(clase, nombre, sang, antig, 0)); }
                    else if(carg == ConsoleKey.B) { equipo.AgregarPersona(new Entrenador(clase, nombre, sang, antig, 1)); }
                    else { equipo.AgregarPersona(new Entrenador(clase, nombre, sang, antig, 2)); }
                }
                else if (a == ConsoleKey.D2 || a == ConsoleKey.NumPad2)
                {
                    Console.WriteLine("\nIngrese nombre del Jugador\n");
                    string nombre = Console.ReadLine();
                    Console.WriteLine($"\nIngrese clase de {nombre}\n");
                    int clase = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nIngrese grupo sanguineo de {nombre}\n");
                    string sang = Console.ReadLine();
                    Console.WriteLine($"\nIngrese la posicion que juega {nombre}\n");
                    string posicion = Console.ReadLine();
                    ConsoleKey s = ConsoleKey.A;
                    while (s != ConsoleKey.S && s != ConsoleKey.N)
                    {
                        Console.WriteLine($"\n{nombre} esta lesionado?\nPresione S o N\n");
                        s = Console.ReadKey().Key;
                    }
                    Console.WriteLine($"\nCuantas faltas tiene {nombre}?\n");
                    int faltas = int.Parse(Console.ReadLine());
                    equipo.AgregarPersona(new Jugador(nombre, clase, sang, posicion, s == ConsoleKey.S, faltas));
                }
            }
            Console.WriteLine(equipo.ListarIntegrantes());
            Console.WriteLine("Ingrese una posicion: \n");
            string pos = Console.ReadLine();
            Console.WriteLine("Ingrese una valoracion: \n");
            int val = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hay {equipo.JugadoresConPosicionValorados(pos, val)} jugador/es que sean {pos} y tengan una valoracion de {val}");
            Console.ReadLine();
        }
    }
}
