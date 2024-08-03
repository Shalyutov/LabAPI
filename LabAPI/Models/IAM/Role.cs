namespace LabAPI.Models.IAM
{
    public class Role
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Permissions { get; set; }
    }
}
