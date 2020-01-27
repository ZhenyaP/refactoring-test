using System.Collections.Generic;
using RefactoringTest.Builders;
using RefactoringTest.Services.Interfaces;

namespace RefactoringTest.Handlers
{
    public class OnlineInstructionHandler : InstructionHandler
    {
        public OnlineInstructionHandler(List<IPaymentFileBuilder> paymentFileBuilders, IPaymentService paymentService) : base(paymentFileBuilders, paymentService)
        {
        }
    }
}