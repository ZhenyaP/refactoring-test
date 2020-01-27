using System.Collections.Generic;
using RefactoringTest.Builders;
using RefactoringTest.Services.Interfaces;

namespace RefactoringTest.Handlers
{
    public class FaxInstructionHandler : InstructionHandler
    {
        public FaxInstructionHandler(List<IPaymentFileBuilder> paymentFileBuilder,
            IPaymentService paymentService)
            : base(paymentFileBuilder, paymentService)
        {
        }
    }
}