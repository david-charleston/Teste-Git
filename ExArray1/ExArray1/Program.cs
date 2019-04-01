using System;

namespace ExArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a pensão da Maria do Bairro!");
            Console.Write("Quantos quartos serão alugados? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Estudantes[] estudantes = new Estudantes[10];

            for (int i = 0; i < quartos; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine().Trim().ToUpper();
                Console.Write("E-mail: ");
                string email = Console.ReadLine().Trim().ToLower();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                estudantes[quarto] = new Estudantes(nome, email);
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine($"{i}: {estudantes[i]}");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
