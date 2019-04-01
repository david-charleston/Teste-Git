using System;
using System.Globalization;

namespace ExClasse5
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            // O objeto chama implicitamento o método ToString
            Console.Write("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qtd = Convert.ToInt32(Console.ReadLine());
            p.AdicionarProduto(qtd);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido: ");
            qtd = Convert.ToInt32(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
