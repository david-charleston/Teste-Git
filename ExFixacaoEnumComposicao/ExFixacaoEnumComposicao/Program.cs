using System;
using ExFixacaoEnumComposicao.Entities;
using ExFixacaoEnumComposicao.Entities.Enums;

namespace ExFixacaoEnumComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("BirhDate (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            // Instanciando o objeto cliente
            Client client = new Client(name, email, birthDate);

            Console.WriteLine();

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(os, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter {i} item data: ");
                Console.Write("Product name: ");
                string nameP = Console.ReadLine();
                Console.Write("Product prince: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameP, price);
                OrderItem orderItem = new OrderItem(quantity, product.Price, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
        }
    }
}
