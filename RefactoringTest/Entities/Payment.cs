using RefactoringTest.Enumerations;

namespace RefactoringTest.Entities
{
    /// <summary>
    /// Stores key information about a payment
    /// </summary>
    public class Payment
    {
        public int Id { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentLeg Leg { get; set; }
    }
}