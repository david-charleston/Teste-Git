using System;
using Services.Interfaces;
using Entities;

namespace Services
{
    class ContractService
    {
        private IPaymentOnlineService _onlinePaymentService;

        public ContractService(IPaymentOnlineService paymentOnlineService)
        {
            _onlinePaymentService = paymentOnlineService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                // Trocando os meses do contrato
                DateTime date = contract.Date.AddMonths(i);
                // Atualizando o valor da parcela
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
