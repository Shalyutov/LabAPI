namespace LabAPI.Models.Laboratory
{
    public class WorkListItem
    {
        public required Referral Referral { get; set; }
        public required Equipment Equipment { get; set; }
        public required Sample Sample { get; set; }
        public DateTime Acquired { get; set; }
        public DateTime Done { get; set; }
        public int Status { get; set; }
    }
}
