using System;
using Entities;
using Services;

namespace ExercicioComInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Alugador de Automóveis");
            Console.WriteLine();
            Console.WriteLine("Entre com os dados do carro:");
            Console.Write("Modelo: ");
            string model = Console.ReadLine();
            Console.Write("Retirada (dd/mm/yyyy hh:mm): ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.Write("Devolução (dd/mm/yyyy hh:mm): ");
            DateTime finish = DateTime.Parse(Console.ReadLine());
            Console.Write("Informe o preço por hora: ");
            double perHour = double.Parse(Console.ReadLine());
            Console.Write("Informe o preço por dia: ");
            double perDay = double.Parse(Console.ReadLine());

            Console.WriteLine();

            // Instânciando o objeto CarRental
            // A classe Vehicle está associada a classe CarRental
            CarRental rental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(perHour, perDay, new BrazilTaxService());
            rentalService.ProcessInvoice(rental);

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para encerrar o programa...");
            Console.ReadKey();
        }
    }
}
