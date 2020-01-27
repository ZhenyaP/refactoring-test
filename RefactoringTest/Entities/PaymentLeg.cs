using RefactoringTest.Enumerations;

namespace RefactoringTest.Entities
{
    public class PaymentLeg
    {
        public PaymentMethod PaymentMethod { get; set; }

        public PaymentLegType Type { get; set; }
    }
}
