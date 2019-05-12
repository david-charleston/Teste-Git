using System;
using ExFicacaoHeranca.Entities;

namespace ExFicacaoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            // Cria o array de Products
            Product[] products = new Product[n];

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{cont} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char d = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (d == 'c')
                {
                    // Instância o produto
                    products[i] = new Product(name, price);
                }
                else if (d == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products[i] = new UsedProduct(name, price, manufactureDate);
                }
                else if (d == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine());

                    products[i] = new ImportedProduct(name, price, customFee);
                }

                cont++;
                Console.WriteLine();
            }

            Console.WriteLine("Price tags:");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].PriceTag());
            }

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
