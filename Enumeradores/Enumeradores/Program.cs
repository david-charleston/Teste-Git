using System;
using Enumeradores.Entities;
using Enumeradores.Entities.Enums;

namespace Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);

            Console.WriteLine();

            Console.Write("Conversão de enum para string: ");
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            Console.WriteLine();

            Console.Write("Conversão de uma string para enum: ");
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para encerrar o programa...");
            Console.ReadLine();
        }
    }
}
