using LabAPI.Models.Laboratory;

namespace LabAPI.Models.Reference
{
    public class Supply
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public string? ShortName { get; set; }
        public required string Supplier {  get; set; }
        public required Biomaterial Biomaterial { get; set; }
        public int Volume { get; set; }
    }
    public record SupplyAccountRecord(Supply Supply, int Value, DateTime Issued, MedicalCenter MedicalCenter);
}
