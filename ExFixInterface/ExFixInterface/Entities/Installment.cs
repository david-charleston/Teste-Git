using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Installment
    {
        public DateTime DateInstallment { get; set; }
        public double ValueInstallment { get; set; }

        public Installment(DateTime dateInstallment, double valueInstallment)
        {
            DateInstallment = dateInstallment;
            ValueInstallment = valueInstallment;
        }

        public override string ToString()
        {
            return $"{DateInstallment} - {ValueInstallment}";
        }
    }
}
