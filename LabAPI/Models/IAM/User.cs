namespace LabAPI.Models.IAM
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string PasswordHash { get; set; }
        public bool IsBlocked { get; set; }
        public string? Email { get; set; }
        public int AccessLevel { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }
    }
}
