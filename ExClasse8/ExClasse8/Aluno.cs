using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasse8
{
    class Aluno
    {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;

        public double NotaFinal()
        {
            return NotaA + NotaB + NotaC;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }
    }
}
