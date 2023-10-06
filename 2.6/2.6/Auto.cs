using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    internal class Auto
    {
        private double fuel;

        public Auto()
        {
            fuel = 0;
        }
        public Auto(double fuel)
        {
            this.fuel = fuel;
            if (fuel > 54)
            {
                this.fuel = 54;
            }

        }
        public double Fuel
        {
            get { return fuel; }
            set
            {
                fuel = value;
                if (fuel > 54) this.fuel = 54;
            }
        }
        public void Conducir(double km)
        {
            if (km / 11 <= fuel)
            {
                fuel -= km / 11;
                Console.WriteLine("Se puede realizar el viaje");
            }
            else Console.WriteLine(String.Format("No se pueder realizar el viaje, con los {0} litros de combustible en el tanque se puede hacer hasta {1} kilometros",
                fuel,fuel*11));

        }
        public void CargarCombustible( double fuel)
        {
            this.fuel += fuel;
            if(this.fuel > 54)
            {
                Console.WriteLine(String.Format("Se derramaron {0} litros de comustible", this.fuel - 54));
                this.fuel = 54;
            }
        }
    }
}
