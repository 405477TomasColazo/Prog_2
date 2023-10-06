using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11
{
    internal class Mazo
    {
        private string [] cartas_actuales;
        private string [] cartas_descartadas;
        private int indice_actual = 0;

        public Mazo()
        {
            cartas_actuales = new string[40];
            cartas_descartadas = new string[40];
            int aux = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (j < 8)
                    {
                        switch (i)
                        {
                            case 0:
                                cartas_actuales[aux] = j.ToString()+" de Espada";
                                aux++;
                                break;
                            case 1:
                                cartas_actuales[aux] = j.ToString() + " de Basto";
                                aux++;
                                break;
                            case 2:
                                cartas_actuales[aux] = j.ToString() + " de Oro";
                                aux++;
                                break;
                            case 3:
                                cartas_actuales[aux] = j.ToString() + " de Copa";
                                aux++;
                                break;
                        }
                    }
                    else
                    {
                        switch (i)
                        {
                            case 0:
                                cartas_actuales[aux] = (j+2).ToString() + " de Espada";
                                aux++;
                                break;
                            case 1:
                                cartas_actuales[aux] = (j+2).ToString() + " de Basto";
                                aux++;
                                break;
                            case 2:
                                cartas_actuales[aux] = (j+2).ToString() + " de Oro";
                                aux++;
                                break;
                            case 3:
                                cartas_actuales[aux] = (j+2).ToString() + " de Copa";
                                aux++;
                                break;
                        }
                    }
                }
            }
        }
        public void barajar()
        {
            int n = cartas_actuales.Length;
            Random r = new Random(cartas_actuales.Length-1);
            for (int i = 0; i < n; i++)
            {
                cambiarLugar(cartas_actuales, i, r.Next(n - 1));
            }
        }
        public void mostrarBaraja()
        {
            for (int i = 0; i < cartas_actuales.Length; i++)
            {
                Console.WriteLine(cartas_actuales[i]);
            }
        }

        public string siguienteCarta()
        {
            return cartas_actuales[0];
        }

        public string darCartas(int n)
        {
            if(n > cartas_actuales.Length)
            {
                return string.Format("No se pueden entregar mas de {0} cartas.",cartas_actuales.Length);
            }
            else //if(n <= 0)
            {
                string aux = "Las cartas son: \n";
                for (int i = 0; i < n; i++)
                {
                    cartas_descartadas[indice_actual] = cartas_actuales[0];
                    indice_actual++;
                    aux += cartas_actuales[0] + "\n";
                    cartas_actuales = cartas_actuales.Skip(1).ToArray();
                }
                return aux;
            }
           // else { return "Ingrese un numero valido"; }
        }

        public void cambiarLugar(string [] mazo, int a, int b)
        {
            string aux = mazo[a];
            mazo[a] = mazo[b];
            mazo[b] = aux;
        }

        public int cartasDisponibles()
        {
            return cartas_actuales.Length;
        }

        public string cartasMonton()
        {
            
            if(cartas_descartadas[0] == null) {return "Todavia no se han descartado cartas"; }
            else
            {
                string aux = "Las cartas descartadas son:\n";
                for (int i = 0; i < cartas_descartadas.Length; i++)
                {
                    aux += cartas_descartadas[i] + "\n";
                }
                return aux;
            }
        }
    }
}
