using LabAPI.Models.Dictionary;

namespace LabAPI.Models.Laboratory
{
    public enum Menopause
    {
        Premenopause, Postmenopause
    }
    public class Referral
    {
        public Int64 Id { get; set; }
        public required Patient Patient { get; set; }
        public DateTime Issued {  get; set; }
        public string? Diagnosis { get; set; }
        public int WeekOfPregnancy { get; set; }
        public Menopause Menopause { get; set; }
        public int HIVStatus { get; set; }
        public int HIVGroup { get; set; }
        public int TickBite { get; set; }
        public string? TickBiteTerritory { get; set; }
        public required Staff Issuer { get; set; }
        public string? ExternalIssuer { get; set; }
        public string? ExternalMedicalCenter { get; set; }
        public required MedicalCenter MedicalCenter { get; set; }
        public string? Comment { get; set; }
    }
    public record ReferralTest(Referral Referral, Test Test);
    public record LabOrder(Referral Referral, Laboratory Laboratory, DateTime Sended);
}
