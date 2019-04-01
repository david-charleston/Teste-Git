using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculador de média salárial";
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            Console.WriteLine("Calculador de média salárial");
            Console.WriteLine();

            Console.WriteLine("Digite o nome do primeiro funcionário: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionario: ");
            f1.Salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Digite o nome do segundo funcionário: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário: ");
            f2.Salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------------------------");
            Console.WriteLine(string.Format("Salário médio: {0:C2}", f1.CalcularMedia(f1.Salario, f2.Salario)));
            Console.WriteLine();
            Console.WriteLine("Digite qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
