using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a cotação do dolar: ");
            double cotacao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar: ");
            double dolar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor a ser pago em reais: " + 
                string.Format("{0:c2}", ConersorMoeda.Converter(cotacao, dolar)));

            Console.WriteLine();
            Console.Write("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
