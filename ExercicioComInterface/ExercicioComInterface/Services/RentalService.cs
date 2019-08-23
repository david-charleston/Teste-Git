using System;
using Entities;

namespace Services
{
    class RentalService
    {
        private ITaxService _taxService;

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental rental)
        {
            double basicPayment = 0.0;

            // Calcula a duração da locação
            TimeSpan duration = rental.Finish.Subtract(rental.Start);

            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);
            rental.Invoice = new Invoice(basicPayment, tax);

            // Imprime na tela o Invoice
            Console.WriteLine("Invoice:");
            Console.WriteLine(rental.Invoice);
        }
    }
}
