using RefactoringTest.Services.Interfaces;

namespace RefactoringTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentService paymentService = new MockPaymentService();
            paymentService.ProcessPayments(paymentService.GetPendingPayments());

            System.Console.ReadLine();
        }
    }
}
