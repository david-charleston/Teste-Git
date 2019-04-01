using System;

namespace OpereadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = 0.0;
            double desconto;

            Console.Write("Digite um preço: ");
            preco = Convert.ToDouble(Console.ReadLine());

            desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine($"O desconto é de {desconto.ToString("F2")}");

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
