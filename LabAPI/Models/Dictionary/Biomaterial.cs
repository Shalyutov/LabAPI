namespace LabAPI.Models.Dictionary
{
    public class Biomaterial
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? ShortName { get; set; }
    }
}
