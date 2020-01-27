using RefactoringTest.Entities;

namespace RefactoringTest.Handlers.Interfaces
{
    public interface IInstructionHandler
    {
        void ProcessInstruction(Payment payment);
    }
}