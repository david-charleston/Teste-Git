using System;
using System.Collections.Generic;
using ExecicioClasseAbstrata.Entities;

namespace ExecicioClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            // Criando a lista
            List<Person> people = new List<Person>();

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char d = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine());

                if (d == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthSpending = double.Parse(Console.ReadLine());

                    // Instânciando o objeto
                    people.Add(new IndividualPerson(name, annualIncome, healthSpending));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    // Instânciando o objeto
                    people.Add(new LegalPerson(name, annualIncome, employees));
                }

                Console.WriteLine();
            }

            Console.WriteLine("Taxes paid: ");
            foreach (Person p in people)
            {
                Console.WriteLine($"{p.Name}: {string.Format("{0:c2}", p.CalcTax())}");
                total += p.CalcTax();
            }

            Console.WriteLine();

            Console.WriteLine($"Total taxes: {string.Format("{0:c2}", total)}");

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
