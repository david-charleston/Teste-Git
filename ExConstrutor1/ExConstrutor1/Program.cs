using System;

namespace ExConstrutor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.45);

            p.Nome = "U";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

            Console.ReadKey();
        }
    }
}
