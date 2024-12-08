using LabAPI.Models.Dictionary;

namespace LabAPI.Models.Laboratory
{
    public class Sample
    {
        public int Id { get; set; }
        public required Referral Referral { get; set; }
        public DateTime Issued { get; set; }
        public int Status { get; set; }
        public required Supply Supply { get; set; }
    }
}
