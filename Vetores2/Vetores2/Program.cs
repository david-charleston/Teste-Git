using System;
using System.Globalization;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;

            // Um vetor de uma classe
            Produtos[] produtos = new Produtos[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Precisamos intanciar para depois armazenar em um vetor de classes
                produtos[i] = new Produtos
                {
                    Nome = name,
                    Preco = price
                };
            }

            for (int i = 0; i < n; i++)
            {
                sum += produtos[i].Preco;
            }
            Console.WriteLine($"A média dos produtos é de {(sum / n).ToString("F2")}");

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
