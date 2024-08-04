namespace LabAPI.Models.Laboratory
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Created {  get; set; }
        public double Discount { get; set; }
    }
    public record PromoCode(string Code, double Amount, DateOnly Expires, Order? Order)
}
