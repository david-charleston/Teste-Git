using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContrutor2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            string titular;
            int numConta;
            string decisao;

            Console.WriteLine("Bem vindo ao banco Nenon");

            Console.WriteLine();

            Console.Write("Entre o número da conta: ");
            numConta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre o nome do titular: ");
            titular = Console.ReadLine().Trim().ToUpper();
            Console.Write("Haverá deposito inicial (s/n)? ");
            decisao = Console.ReadLine();

            if (decisao.Equals("s"))
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double saldo = Convert.ToDouble(Console.ReadLine());

                conta = new ContaBancaria(numConta, titular, saldo);
            }
            else
            {
                conta = new ContaBancaria(numConta, titular);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            conta.Despositar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre u valor para saque: ");
            conta.Sacar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Aperte qualquer tecla para continuar...");

            Console.ReadKey();
        }
    }
}
