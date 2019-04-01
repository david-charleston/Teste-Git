using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * A palavra reservada ref faz com que o parâmetro seja uma
             * referência da variável original.
             * A palavra ref é um modificador de parâmetro.
             * O ref requer que a variável seja inicializada
            */

            Console.WriteLine("Exemplo com o modificador ref");
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            Console.WriteLine();

            /**
             * A palavra reservada out faz a mesma coisa que a ref, porém 
             * ela não necessita que a variável seja inicializada
             */
            Console.WriteLine("Exemplo com o modificador out");
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine($"O triplo de {a} é {triple}");

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
