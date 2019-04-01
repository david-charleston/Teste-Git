using System;

namespace ExemploNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // O Nullable permite que structs guardem o valor nulo
            Nullable<double> x = null;
            // Essa é outra maneira de fazer um struct guardar um valor null
            double? y = null;
            double? z = 10.0;

            double a = x ?? 6.0;

            // Retorna o valor da variável se tiver e senão tiver retorna o padrão
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(z.GetValueOrDefault());

            Console.WriteLine();

            // Retorna true ou false
            Console.WriteLine(y.HasValue);
            Console.WriteLine(z.HasValue);

            Console.WriteLine();

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            if (z.HasValue)
            {
                Console.WriteLine(z.Value);
            }
            else
            {
                Console.WriteLine("Z is null");
            }

            Console.ReadKey().ToString();
        }
    }
}
