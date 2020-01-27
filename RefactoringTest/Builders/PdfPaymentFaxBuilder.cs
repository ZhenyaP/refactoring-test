using RefactoringTest.Entities;

namespace RefactoringTest.Builders
{
    public class PdfPaymentFaxBuilder : IPaymentFileBuilder
    {
        public string Build(Payment payment)
        {
            return string.Empty;
        }
    }
}
