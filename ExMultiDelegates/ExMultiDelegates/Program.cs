using ExMultiDelegates.Services;

namespace ExMultiDelegates
{
    delegate void CalculationOperation(double x, double y);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 55;
            double b = 50;

            /**
             *  Multi delegate executa as funções que ele faz referência
             *  na ordem que lhe foram atribuidas
             */
            CalculationOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;

            op.Invoke(a, b);
        }
    }
}
