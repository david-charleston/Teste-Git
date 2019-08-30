using System;
using ExPredicate.Entities;
using System.Collections.Generic;

namespace ExPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("TV", 900.00),
                new Product("Mouse", 50.00),
                new Product("Tablet", 350.00),
                new Product("HD Case", 80.90)
            };

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            Console.WriteLine("Removendo os produtos com o valor acima de R$ 100");
            products.RemoveAll(Remove);

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        public static bool Remove(Product product)
        {
            return (product.Price >= 100.00) ? true : false;
        }
    }
}
