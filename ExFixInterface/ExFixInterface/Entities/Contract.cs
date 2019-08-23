using System;
using System.Collections.Generic;

namespace Entities
{
    class Contract
    {
        public int NumberContract { get; set; }
        public DateTime DateContract { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int numberContract, DateTime dateContract, double totalValue)
        {
            NumberContract = numberContract;
            DateContract = dateContract;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
