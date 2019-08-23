﻿using System;
using Services.Interfaces;

namespace Services
{
    class PayPalService : IPaymentOnlineService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double Interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }
    }
}
