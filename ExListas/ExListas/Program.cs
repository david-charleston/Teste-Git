using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employers> employees = new List<Employers>();

            Console.Write("Quantos funcionário serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Empregado #{i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employers(id, name, salary));

                Console.WriteLine();
            }

            Console.Write("Digite o id do funcionário que irá ter um aumento: ");
            int findId = int.Parse(Console.ReadLine());

            Employers emp = employees.Find(x => x.Id == findId);
            if (emp != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine());

                emp.RaiseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Esse id não existe!");
            }

            Console.WriteLine();

            Console.WriteLine("Lista atualizada dos funcionários: ");
            foreach (Employers item in employees)
            {
                Console.WriteLine(item);
            }

            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
