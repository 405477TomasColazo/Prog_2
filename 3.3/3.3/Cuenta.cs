using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    internal class Cuenta
    {
        private int numero;
        private int tipo;
        private double saldo;
        private Cliente cliente;

        public Cuenta()
        {
            numero = 0;
            tipo = 0;
            saldo = 0;
            cliente = new Cliente();
        }
        public Cuenta(int numero, int tipo, double saldo, Cliente cliente)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.saldo = saldo;
            this.cliente = cliente;
        }
        public int pNumero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int pTipo
        {
            get { return tipo; }
            set { if (value == 1 | value == 2) { tipo = value; } }
        }
        public double pSaldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public Cliente pCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
    }
}
