using System;
using ExercicioSemInterface.Entities;

namespace ExercicioSemInterface.Services
{
    class Rentalservice
    {
        private BrasilTaxService _brasilTaxService = new BrasilTaxService();

        public double PricePerDay { get; private set; }
        public double PricePerHour { get; private set; }


        public Rentalservice(double perDay, double perHour)
        {
            PricePerDay = perDay;
            PricePerHour = perHour;
        }

        public void ProcessInvoice(CarRental rental)
        {
            // Armazena a duração de locação do carro
            TimeSpan duration = rental.Finish.Subtract(rental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12)
            {
                // Multiplica o valor por hora pela duração arrendondada para cima
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            // Calcula o imposto de acordo com o valor calculado anteriormente
            double tax = _brasilTaxService.Tax(basicPayment);

            // O Invoice será processado pela classe RentalService
            rental.Invoice = new Invoice(basicPayment, tax);
            Console.WriteLine("INVOICE:");
            Console.WriteLine(rental.Invoice);
        }
    }
}
