using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10
{
    internal class Tanque
    {
        double fuel;
        Tanque()
        {
            fuel = 0;
        }

        public Tanque(double fuel)
        {
            this.fuel = fuel;
        }
        double Fuel
        {
            get { return fuel; }
            set {
                fuel = value;
                if (fuel < 0) { fuel = 0; }
                if (fuel > 49) { fuel = 49; }
            }
        }
   }
}
