using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("----------Comparador de idade----------");
            Console.WriteLine();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa: ");
            p1.Idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa: ");
            p2.Idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }

            Console.WriteLine();
            Console.Write("Digite qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
