using System;
using System.Collections.Generic;
using ExFunc.Entities;
using System.Linq;

namespace ExFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("TV", 900.00),
                new Product("Mouse", 50.00),
                new Product("Tablet", 350.50),
                new Product("HD Case", 80.90)
            };

            /**
             * O Select recebe um Func e retorna um IEnumarable
             * O IEnumarable precisa ser convertido em List
             * O Select retorna uma nova coleção 
            */
            Func<Product, string> func = p => p.Name.ToUpper();
            List<string> resultUpper = products.Select(func).ToList();

            foreach (string item in resultUpper)
            {
                Console.WriteLine(item);
            }
        }
    }
}
