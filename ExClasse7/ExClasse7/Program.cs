using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse7
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Entre com os dados do funcionário: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine().ToUpper().Trim();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + f);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double perc = Convert.ToDouble(Console.ReadLine());
            f.AumentarSalario(perc);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + f);

            Console.ReadKey();
        }
    }
}
