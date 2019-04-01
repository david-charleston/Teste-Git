using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trabalhando com Struct
            // O struct não precisa ser instânciado
            // O struct precisa ser inicializado
            // atribuindo valores para ele ou instânciando
            Point p;
            p.X = 15;
            p.Y = 45;

            Console.WriteLine(p);

            Point point = new Point();
            Console.WriteLine(point);

            Console.ReadKey();
        }
    }
}
