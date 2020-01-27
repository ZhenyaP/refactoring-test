using System;
using System.Collections.Generic;
using Polly;
using RefactoringTest.Entities;
using RefactoringTest.Factories;
using RefactoringTest.Services.Interfaces;

namespace RefactoringTest.Services
{
    public class PaymentService : IPaymentService
    {
        public virtual List<Payment> GetPendingPayments()
        {
            return new List<Payment>();
        }

        public void ReleasePayment(int id)
        {
            Console.WriteLine("Released Payment {0}", id);
        }

        private void ProcessPayment(InstructionHandlerFactory factory,
                                    Payment payment)
        {

            var handler = factory.GetHandler(payment);
            handler.ProcessInstruction(payment);
        }

        public void ProcessPayments(List<Payment> payments)
        {
            var instructionHandlerFactory = new InstructionHandlerFactory();
            //TODO: Replace Exception with more specific exception type in policy
            var policy = Policy
                .Handle<Exception>()
                .Retry(Config.ProcessPaymentRetryCount,
                    (exPendingPayment, retryCount, context) =>
                    {
                        Logger.Log(exPendingPayment.Message);
                    });

            foreach (var payment in payments)
            {
                policy.Execute(() => ProcessPayment(instructionHandlerFactory, payment));
            }
        }
    }
}
