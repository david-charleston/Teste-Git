using System;
using TryCatchPersonalizado.Entities;
using TryCatchPersonalizado.Entities.Exceptions;

namespace TryCatchPersonalizado
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/mm/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/mm/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                // Criando o objeto reserva
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date ()dd/mm/yyyy: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation);
            }
            catch (DomainException ex)
            {
                Console.WriteLine($"Error in reservation: {ex.Message}");
            }
            
        }
    }
}
