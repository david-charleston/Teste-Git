using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse6
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            r.Largura = Convert.ToDouble(Console.ReadLine());
            r.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area: " + r.Area());
            Console.WriteLine("Perímetro: " + r.Perimetro());
            Console.WriteLine("Diagonal: " + r.Diagonal());

            Console.ReadKey();
        }
    }
}
