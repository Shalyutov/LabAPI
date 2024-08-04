namespace LabAPI.Models.Reference
{
    public class Service
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public string? ShortName { get; set; }
    }
    public record ServicePrice(Service Service, DateOnly Issued, double Cost);
}
