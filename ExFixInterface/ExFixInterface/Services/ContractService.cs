using System;
using Entities;
using Services.Interface;

namespace Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            // Taxa básica do contrato
            double basicValue = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                // Troca o mês do contrato
                DateTime date = contract.DateContract.AddMonths(i);
                double updateValue = basicValue + _onlinePaymentService.InterestRate(basicValue, i);
                double fullValue = updateValue + _onlinePaymentService.Payment(updateValue);
                // Adicona a parcela a coleção
                contract.AddInstallment(new Installment(date, fullValue));
            }
        }
    }
}
