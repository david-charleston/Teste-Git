using System;
using Services.Interface;

namespace Services
{
    class PayPalService : IOnlinePaymentService
    {
        public double Payment(double amount)
        {
            return amount * 0.02;
        }

        public double InterestRate(double amount, int months)
        {
            return amount * 0.01 * months;
        }
    }
}
