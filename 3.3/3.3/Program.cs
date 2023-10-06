using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Cuenta> cuentasBanco = new List<Cuenta>();
			List<Cliente> clientes = new List<Cliente>();
			int aux = 0;
			bool menu = true;
			int cajaNro = 1;
			double saldo1 = 0;
			void crearCajaAhorro()
            {
				Console.WriteLine("\nEl nro de su caja de ahorro es: " + cajaNro);
				Console.WriteLine("Cuanto saldo ingresara a la cuenta?\n");
				saldo1 = Convert.ToDouble(Console.ReadLine());
				cuentasBanco.Add(new Cuenta(cajaNro, 1, saldo1, clientes[aux]));
				cajaNro++;
			}
			void crearCuentaCorriente()
            {
				Console.WriteLine("\nEl nro de su cuenta corriente es: " + cajaNro);
				Console.WriteLine("Cuanto saldo ingresara a la cuenta?\n");
				saldo1 = Convert.ToDouble(Console.ReadLine());
				cuentasBanco.Add(new Cuenta(cajaNro, 2, saldo1, clientes[aux]));
				cajaNro++;
			}
			double saldoPromedio(int tipo)
            {
				double [] total = {0,0};
				if (tipo == 0) { foreach (Cuenta cuenta in cuentasBanco) { total[0] += cuenta.pSaldo; total[1]++; } }
                foreach(Cuenta cuenta in cuentasBanco) { if (cuenta.pTipo == tipo) { total[0] += cuenta.pSaldo; total[1]++;} }
				return total[0]/total[1];
            }
			double clientesFem()
            {
				double fem = 0;
				foreach (Cliente cliente in clientes) { if (cliente.pSexo == "F") { fem++; } }
				return 100*fem/clientes.Count();
            }
			int indexLimite()
            {
				double [] limite = {0,0};
                for (int i = 0; i < clientes.Count(); i++)
                {
					if (clientes[i].pLimite_credito > limite[0]) { limite[0] = clientes[i].pLimite_credito; limite[1] = i; }
                }
				return Convert.ToInt32(limite[1]);
            }
			while (menu)
			{
				Console.WriteLine("\nSi desea ingresar un nuevo cliente presione 'A'\n" +
					"Si desea saber la informacion general de las cuentas del banco presione 'S'\n" +
					"Si desea cerrar el menu presione 'Escape'\n");
				ConsoleKey a = Console.ReadKey().Key;
				switch (a)
				{
					case ConsoleKey.A:
						clientes.Add(new Cliente());
						Console.WriteLine("\nIngrese el nombre del cliente:\n");
						clientes[aux].pNombre = Console.ReadLine();
						Console.WriteLine("\nIngrese DNI del cliente:\n");
						clientes[aux].pDni = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("\nIngrese sexo del cliente (H o F)\n");
						ConsoleKey tecla = ConsoleKey.C;
						while(tecla != ConsoleKey.H & tecla != ConsoleKey.F) { tecla = Console.ReadKey().Key; }
						clientes[aux].pSexo = tecla.ToString();
						Console.WriteLine("\nIngrese el condigo que tendra el cliente:\n");
						clientes[aux].pCodigo = Console.ReadLine();
						Console.WriteLine("\nIngrese el limite de credito que dispondra:\n");
						clientes[aux].pLimite_credito = Convert.ToInt32(Console.ReadLine());
						ConsoleKey c = ConsoleKey.C;
						while(c != ConsoleKey.D1 & c != ConsoleKey.D2 & c != ConsoleKey.D3 & c != ConsoleKey.NumPad1 & c != ConsoleKey.NumPad2 & c != ConsoleKey.NumPad3)
						{
							Console.WriteLine("\nSeleccione una opcion para su cuenta/s\n" +
							"1) Caja de ahorro.\n" +
							"2) Cuenta corriente.\n" +
							"3) Ambas opciones.\n");
							c = Console.ReadKey().Key;
						}
						switch (c)
						{
							case ConsoleKey.D1:
							case ConsoleKey.NumPad1:
								crearCajaAhorro();
								break;
							case ConsoleKey.D2:
							case ConsoleKey.NumPad2:
								crearCuentaCorriente();
								break;
							case ConsoleKey.D3:
							case ConsoleKey.NumPad3:
								crearCajaAhorro();
								crearCuentaCorriente();
								break;
						}
						break;
					case ConsoleKey.S:
						Console.WriteLine(String.Format("\nHay un total de {0} de cuentas, siendo {1} cajas de ahorro y {2} cuentas corrientes con un total de {3} clientes.\n",
							cuentasBanco.Count(),cuentasBanco.Count(cuenta =>cuenta.pTipo == 1),cuentasBanco.Count(cuenta => cuenta.pTipo == 2),clientes.Count()) + 
							String.Format("El saldo promedio en las cuentas del banco es de {0} pesos, siendo {1} pesos el saldo promedio de las cajas de ahorro y {2} pesos el saldo promedio de las cuentas Corrientes.",
							saldoPromedio(0),saldoPromedio(1),saldoPromedio(2))+$"\nLos clientes femeninos son un %{clientesFem()} de los clientes del banco.\n" +
							$"El cliente con mayor limite de credito es {clientes[indexLimite()].pNombre} con un total de {clientes[indexLimite()].pLimite_credito} pesos como limite.\n");
						break;
					case ConsoleKey.Escape:
						menu = false;
						break;
				}
			}
		}
	}
}
