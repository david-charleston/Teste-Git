using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse2
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public double CalcularMedia(double salario1, double salario2)
        {
            return (salario1 + salario2) / 2;
        }
    }
}
