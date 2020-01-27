using System.Collections.Generic;
using RefactoringTest.Builders;
using RefactoringTest.Entities;
using RefactoringTest.Services.Interfaces;

namespace RefactoringTest.Handlers
{
    public class WebEntryInstructionHandler : InstructionHandler
    {
        public override void ProcessInstruction(Payment payment)
        {
            ReleaseInstruction(payment);
        }

        public WebEntryInstructionHandler(List<IPaymentFileBuilder> paymentFileBuilders, IPaymentService paymentService)
            : base(paymentFileBuilders, paymentService)
        {
        }
    }
}