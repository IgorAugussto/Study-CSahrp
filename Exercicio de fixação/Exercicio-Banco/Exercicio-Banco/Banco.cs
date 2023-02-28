using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Banco
{
    internal class Banco
    {
        public string Titular { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Banco(string titular, int numero)
        {
            Titular = titular;
            Numero = numero;
        }

        public Banco (int numero, string titular, double depositoInicial) : this(titular, numero)
        {
           Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("F2");
        }


    }
}
