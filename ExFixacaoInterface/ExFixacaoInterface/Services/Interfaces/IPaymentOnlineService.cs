using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    interface IPaymentOnlineService
    {
        double PaymentFee(double amount);
        double Interest(double amounnt, int months);
    }
}
