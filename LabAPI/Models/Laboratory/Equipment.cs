namespace LabAPI.Models.Laboratory
{
    public class Equipment
    {
        public int Id { get; set; }
        public required string Supplier { get; set; }
        public required string Name { get; set; }
        public required Laboratory Laboratory { get; set; }
    }
}
