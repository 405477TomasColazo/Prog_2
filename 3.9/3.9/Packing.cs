using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9
{
    internal class Packing : Carga
    {
        private string tipo;

        public string pTipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private int cant_cajas;

        public int pCant_cajas
        {
            get { return cant_cajas; }
            set { cant_cajas = value; }
        }
        private double peso_cajas;

        public  double pPeso_cajas
        {
            get { return peso_cajas; }
            set { peso_cajas = value; }
        }
        private double peso_tarima;

        public double pPeso_tarima
        {
            get { return peso_tarima; }
            set { peso_tarima = value; }
        }

        public Packing():base()
        {
            tipo = "";
            cant_cajas = 0;
            peso_cajas = 0;
            peso_tarima = 0;
        }
        public Packing(string tipo,int cajas,double pCajas, double pTarima):base()
        {
            this.tipo = tipo;
            cant_cajas = cajas;
            peso_cajas = pCajas;
            peso_tarima = pTarima;
        }
        public override double peso()
        {
            return cant_cajas * peso_cajas + peso_tarima;
        }
    }

}
