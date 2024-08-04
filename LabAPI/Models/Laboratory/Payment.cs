namespace LabAPI.Models.Laboratory
{
    public enum PaymentMethod
    {
        Cash, Cashless, Account, Other
    }
    public class Payment
    {
        public int Id { get; set; }
        public DateTime Issued { get; set; }
        public double Amount { get; set; }
        public PaymentMethod Method { get; set; }
        public required Order Order { get; set; }
    }
    public record Refund(Payment Payment, DateTime Issued);
    public record CustomRefund(Order Order, double Amount, DateTime Issued);
}
