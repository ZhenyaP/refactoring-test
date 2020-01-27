using System.Collections.Generic;
using RefactoringTest.Builders;
using RefactoringTest.Entities;
using RefactoringTest.Enumerations;
using RefactoringTest.Handlers.Interfaces;
using RefactoringTest.Helpers;
using RefactoringTest.Services.Interfaces;

namespace RefactoringTest.Handlers
{
    public class InstructionHandler : IInstructionHandler
    {
        protected readonly List<IPaymentFileBuilder> PaymentFileBuilders;
        protected readonly IPaymentService PaymentService;

        public InstructionHandler(List<IPaymentFileBuilder> paymentFileBuilders,
            IPaymentService paymentService)
        {
            this.PaymentFileBuilders = paymentFileBuilders;
            this.PaymentService = paymentService;
        }

        public virtual void ProcessInstruction(Payment payment)
        {
            foreach (var paymentFileBuilder in PaymentFileBuilders)
            {
                var file = paymentFileBuilder.Build(payment);
                EmailerHelper.SendEmailWithAttachment(Config.EmailContact, file);
            }

            ReleaseInstruction(payment);
        }

        protected void ReleaseInstruction(Payment payment)
        {
            if (payment.Leg.Type == PaymentLegType.Original)
                this.PaymentService.ReleasePayment(payment.Id);
        }
    }
}