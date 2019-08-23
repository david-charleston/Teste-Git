using System;
using Entities;
using Services;

namespace ExFixacaoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao gerador de contratos!");
            Console.WriteLine();
            Console.WriteLine("Entre com os dados do contrato: ");
            Console.Write("Número: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/mm/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor do contrato: ");
            double totalValue = double.Parse(Console.ReadLine());
            Console.Write("Entre com a quantidade de parcelas: ");
            int months = int.Parse(Console.ReadLine());

            // Instânciando o contrato
            Contract contract = new Contract(number, date, totalValue);
            ContractService contractService = new ContractService(new PayPalService());
            // Processando os contratos
            contractService.ProcessContract(contract, months);


            Console.WriteLine();

            Console.WriteLine("Parcelas: ");
            for (int i = 0; i < contract.Installments.Count; i++)
            {
                Console.WriteLine(contract.Installments[i]);
            }

            Console.WriteLine();
            Console.Write("Obrigado por o gerador de contratos!");
            Console.ReadKey();
        }
    }
}
