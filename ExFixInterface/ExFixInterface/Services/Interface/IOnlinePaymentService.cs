namespace Services.Interface
{
    interface IOnlinePaymentService
    {
        double Payment(double amount);
        double InterestRate(double amount, int months);
    }
}
