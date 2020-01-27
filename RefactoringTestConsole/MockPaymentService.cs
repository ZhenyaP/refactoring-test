using System.Collections.Generic;
using RefactoringTest.Entities;
using RefactoringTest.Enumerations;
using RefactoringTest.Services;

namespace RefactoringTestConsole
{
    public class MockPaymentService : PaymentService
    {
        public override List<Payment> GetPendingPayments()
        {
            //implementation to return payments
            return new List<Payment>
                       {
                           new Payment
                           {
                               Id = 1,
                               Method = PaymentMethod.Fax,
                               Leg = new PaymentLeg
                               {
                                   PaymentMethod = PaymentMethod.Fax
                               }
                           },
                           new Payment
                           {
                               Id = 2,
                               Method = PaymentMethod.Online,
                               Leg  = new PaymentLeg
                               {
                                   PaymentMethod = PaymentMethod.Online
                               }
                           },
                           new Payment
                           {
                               Id = 3,
                               Method = PaymentMethod.WebEntry,
                               Leg = new PaymentLeg
                               {
                                   PaymentMethod = PaymentMethod.WebEntry
                               }
                           },
                           new Payment
                           {
                               Id = 4,
                               Method = PaymentMethod.Fax,
                               Leg = new PaymentLeg
                               {
                                   PaymentMethod = PaymentMethod.Online
                               }
                           }
                       };
        }
    }
}