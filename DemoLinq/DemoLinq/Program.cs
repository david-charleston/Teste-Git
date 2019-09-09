using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq.Entities;

namespace DemoLinq
{
    class Program
    {
        // Função auxíliar para printar na tela
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("Tier 1 and price < 900: ", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Names of products of category tools: ", r2);

            // Retorna os dados que começam com a letra C e apenas os atributos que foram especificados
            var r3 = products.Where(p => p.Name[0] == 'C')
                .Select(p => new { Nome = p.Name, Preço = p.Price, Categoria = p.Category.Name });
            Print("Names started with C and Anonymous Object", r3);

            // Ordenando por preço e por nome
            var r4 = products.Where(p => p.Category.Tier == 1)
                .OrderBy(p => p.Price)
                .ThenBy(p => p.Name);
            Print("Order by price then name: ", r4);

            // Skip e Take serve para paginação
            // O skip está pulando os dois primeiros resultados
            // O take está pegando apenas 4 resultados
            var r5 = r4.Skip(2).Take(4);
            Print("Order by price then name skip 2 take 4: ", r5);

            // First retorna o primeiro elemento do source
            var r6 = products.First();
            Console.WriteLine($"First test 1: {r6}");
            var r7 = products.Where(p => p.Price > 4500).FirstOrDefault();
            Console.WriteLine($"First or default test 2: {r7}");
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine($"Single or default: {r8}");

            Console.WriteLine();

            // Operações de agregação
            // Retorna o maior preço da coleção
            var r9 = products.Max(p => p.Price);
            Console.WriteLine($"Max price: {r9}");
            // Retorna o menor preço da coleção
            var r10 = products.Min(p => p.Price);
            Console.WriteLine($"Min price: {r10}");
            // Retorna a somatória dos produtos de categoria 1
            var r11 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine($"Categoty 1 Sum prices: {r11}");
            // Retorna a média dos preços dos produtos
            var r12 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine($"Category 1 avarage prices: {r12}");
            // Vai retornar zero se a coleção for vazia
            var r13 = products.Where(p => p.Category.Id == 5)
                .Select(p => p.Price)
                .DefaultIfEmpty(0.0)
                .Average();
            Console.WriteLine($"Category 5 avarage prices: {r13}");
            var r14 = products.Where(p => p.Category.Id == 1)
                .Select(p => p.Price)
                .Aggregate((p1, p2) => p1 + p2);
            Console.WriteLine($"Category 1 sum prices with aggregate: {r14}");

            Console.WriteLine();

            // Funções de agrupamento
            var r15 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> item in r15)
            {
                Console.WriteLine($"Category: {item.Key.Name}");
                foreach (Product prod in item)
                {
                    Console.WriteLine(prod.Name);
                }
                Console.WriteLine();
            }
        }
    }
}
