using System;

namespace ExParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Params é um modificador de parâmetros
            // O params pertique que varios parâmetros possam ser passados para o método
            //int s1 = Calculator.Sum(2, 3);
            //int s2 = Calculator.Sum(2, 3, 4);

            // Com o params não é necessário criar um vetor, basta apenas passar os valores

            // Jeito antigo
            //int s1 = Calculator.Sum(new int[] { 10, 20, 30, 40 });

            // Novo jeito
            int s1 = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(s1);

            Console.ReadKey();
        }
    }
}
