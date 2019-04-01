using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContrutor2
{
    public class ContaBancaria
    {
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string titular)
        {
            NumConta = numConta;
            Titular = titular;
            Saldo = 0;
        }

        // Lembrar de deixar os construtores publicos
        public ContaBancaria(int numConta, string titular, double saldo)
        {
            NumConta = numConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Despositar(double quantia)
        {
            Saldo += quantia;
        } 

        public void Sacar(double quantia)
        {
            Saldo -= (quantia + 5);
        }

        public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + string.Format("{0:c2}", Saldo);
        }
    }
}
