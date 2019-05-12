using System;
using ExercicioHeranca.Entities;

namespace ExercicioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            string name;
            double hours, valuePerHour, additionalCharge;

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            // Instânciando o array de funcionários
            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{cont} data:");
                Console.Write("Outsourced (y/n)? ");
                string outsorced = Console.ReadLine();

                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Hours: ");
                hours = double.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine());

                if (outsorced == "n")
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees[i] = employee;
                }
                else
                {
                    Console.Write("Additional charge: ");
                    additionalCharge = double.Parse(Console.ReadLine());

                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees[i] = employee;
                }

                cont++;

                Console.WriteLine();
            }
        }
    }
}
