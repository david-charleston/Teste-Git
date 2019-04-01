using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse7
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiq()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            return SalarioBruto += (SalarioBruto * (porcentagem / 100));
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + string.Format("{0:c2}", SalarioLiq());
        }
    }
}
