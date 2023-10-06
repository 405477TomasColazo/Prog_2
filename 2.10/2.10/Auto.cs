using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10
{
    internal class Auto
    {
        double reserva;

        public Auto()
        {
            reserva = 0;
        }
        public Auto(double fuel)
        {
            reserva = fuel;
        }
        public double Reserva
        {
            get { return reserva; }
            set
            {
                reserva = value;
                if (reserva < 0) { reserva = 0; }
                if (reserva > 5) { reserva = 5; }
            }
        }
        public void CargarCombustible(double fuel)
        {
            if (reserva + Tanque
        }
    }
     
}
