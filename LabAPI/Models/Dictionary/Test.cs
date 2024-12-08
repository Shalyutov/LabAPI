namespace LabAPI.Models.Dictionary
{
    public enum TestType
    {
        Integer, Binary, Text, Mixed
    }
    public class Test
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public string? ShortName { get; set; }
        public required TestType Type { get; set; }
        public bool IsSeparated { get; set; }
        public IEnumerable<Supply> Supplies { get; set; } = [];
        public IEnumerable<Indicator> Indicators { get; set; } = [];
        public IEnumerable<Service> Services { get; set; } = [];
    }
}
