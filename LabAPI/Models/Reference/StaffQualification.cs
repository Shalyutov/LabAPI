namespace LabAPI.Models.Reference
{
    public class StaffQualification
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Category { get; set; }
        public int Level { get; set; }
    }
}
