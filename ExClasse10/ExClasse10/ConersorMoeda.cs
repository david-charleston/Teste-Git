using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse10
{
    static class ConersorMoeda
    {
        public static double IOF = 0.06;

        public static double Converter(double cotacao, double quantia)
        {
            double total = cotacao * quantia;
            return total += (total * IOF);
        }
    }
}
