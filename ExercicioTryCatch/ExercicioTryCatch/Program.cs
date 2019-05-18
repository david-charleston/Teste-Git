using System;
using ExercicioTryCatch.Entities;
using ExercicioTryCatch.Entities.Exceptions;

namespace ExercicioTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Atomic Bank");

            Console.WriteLine();
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                // Instânciando o objeto Account
                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);

                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }

            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
