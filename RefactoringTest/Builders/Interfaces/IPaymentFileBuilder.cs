using RefactoringTest.Entities;

namespace RefactoringTest.Builders
{
    public interface IPaymentFileBuilder
    {
        string Build(Payment payment);
    }
}
