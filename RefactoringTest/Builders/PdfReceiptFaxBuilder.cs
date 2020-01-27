using RefactoringTest.Entities;

namespace RefactoringTest.Builders
{
    public class PdfReceiptFaxBuilder : IPaymentFileBuilder
    {
        public string Build(Payment payment)
        {
            return string.Empty;
        }
    }
}
