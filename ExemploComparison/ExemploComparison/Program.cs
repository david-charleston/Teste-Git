using System;
using System.Collections.Generic;
using ExemploComparison.Entities;

namespace ExemploComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>
            {
                new Product("TV", 1250),
                new Product("Notebook", 2755),
                new Product("Armário", 575),
                new Product("Celular", 1275)
            };

            list.Sort();

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }

            Console.ReadKey();
        }
    }
}
