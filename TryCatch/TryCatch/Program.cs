using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o 1º número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o 2º número: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Impossível dividir por zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor foi informado incorretamente!");
            }
            
        }
    }
}
