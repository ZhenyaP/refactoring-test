using System.Collections.Generic;
using RefactoringTest.Entities;

namespace RefactoringTest.Services.Interfaces
{
    public interface IPaymentService
    {
        List<Payment> GetPendingPayments();
        void ReleasePayment(int id);
        void ProcessPayments(List<Payment> payments);
    }
}