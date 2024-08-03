namespace LabAPI.Models.Reference
{
    public class Biomaterial
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? ShortName { get; set; }
    }
}
