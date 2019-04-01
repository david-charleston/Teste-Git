using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int pessoas;

            Console.Write("Digite a quantidade de pessoas: ");
            pessoas = Convert.ToInt32(Console.ReadLine());

            double[] alturas = new double[pessoas];

            for (int i = 0; i < pessoas; i++)
            {
                alturas[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0.0;

            for (int i = 0; i < pessoas; i++)
            {
                sum += alturas[i];
            }

            double media = sum / pessoas;

            Console.WriteLine($"Média: {media.ToString("F2")}" );
            Console.ReadKey();
        }
    }
}
