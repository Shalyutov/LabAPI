namespace LabAPI.Models.IAM
{
    public class Permission
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime Granted { get; set; }
        public DateTime Expires { get; set; }
        public required User User { get; set; }
    }
}
