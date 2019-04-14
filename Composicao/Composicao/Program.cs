using System;
using System.Globalization;
using Composicao.Entities;
using Composicao.Entities.Enums;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament departament = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, departament);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{cont} contract data: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value, hours);
                worker.AddContract(contract);
                cont++;
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"Income for {month}/{year}: {worker.Income(year, month).ToString("F2")}");
        }
    }
}
