using ExDelegate.Services;

namespace ExDelegate
{
    // Definição de delegate
    // O Delegate é um type safety
    // O Delegate pode receber uma função como parâmetros
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // Ele faz referência a este método
            BinaryNumericOperation op = CalculationService.Sum;
            // O método foi chamado através do delegate
            double result = op(a, b);

            System.Console.WriteLine(result);
        }
    }
}
