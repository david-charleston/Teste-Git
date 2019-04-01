using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingEUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Boxing é o processo de conversão de um objeto de um tipo valor
             * para um objeto de tipo referência compativel
            */
            int x = 20;
            // O Object é compativel com qualquer outro tipo
            // Boxing
            Object obj = x;
            // Unboxing
            // Obs.: eles necessitam ser do mesmo tipo
            int y = (int)obj;


            Console.WriteLine(obj);
        }
    }
}
