using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9
{
    internal class Camion
    {
        private double max_Capacidad;

        public double pMax_Capacidad
        {
            get { return max_Capacidad; }
            set { max_Capacidad = value; }
        }
        private int estado;
        // |0 disponible para carga |1 en viaje |2 en reparacion|
        public int pEstado
        {
            get { return estado; }
            set { estado = value; }
        }
        private List<Carga> cargas;

        public List<Carga> pCargas
        {
            get { return cargas; }
            set { cargas = value; }
        }
        public Camion()
        {
            max_Capacidad = 100;
            estado = 0;
            cargas = new List<Carga>();
        }
        public Camion(double cap,int estado)
        {
            max_Capacidad = cap;
            this.estado = estado;
            cargas = new List<Carga>();
        }
    }
}
