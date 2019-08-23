using System;
using Services;
using Entities;

namespace ExFixInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerador de parcelas!!!");
            Console.WriteLine();
            Console.WriteLine("Entre com os dados do contrato: ");
            Console.Write("Número do Contrato: ");
            int numContract = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/mm/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor do contrato: ");
            double totalValue = double.Parse(Console.ReadLine());
            Console.Write("Entre com as quantidades de parcelas: ");
            int installment = int.Parse(Console.ReadLine());

            // Instânciando o contrato
            Contract contract = new Contract(numContract, date, totalValue);
            ContractService cs = new ContractService(new PayPalService());
            // Processando o contrato
            cs.ProcessContract(contract, installment);

            Console.WriteLine();

            Console.WriteLine("Installments: ");
            foreach (Installment item in contract.Installments)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Obrigado por usar o Gerador de Parcelas");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadLine();
        }
    }
}
