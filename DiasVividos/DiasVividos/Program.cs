using System;

namespace DiasVividos
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataNasc;
            TimeSpan result;
            int ano, mes, dia;

            Console.Write("Informe o seu ano de nascimento: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o seu mês de nascimento: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o seu dia de nascimento: ");
            dia = Convert.ToInt32(Console.ReadLine());

            dataNasc = new DateTime(ano, mes, dia);

            result = dataAtual.Subtract(dataNasc);

            Console.WriteLine();
            Console.WriteLine($"Você viveu {result.ToString("dd")} dias!");

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
