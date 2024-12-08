using LabAPI.Models.Dictionary;

namespace LabAPI.Models.Laboratory
{
    public class TestResult
    {
        public required Referral Referral { get; set; }
        public required Test Test { get; set; }
        public required Indicator Indicator { get; set; }
        public DateTime Issued { get; set; }
        public required Staff Issuer { get; set; }
        public DateTime Confirmed { get; set; }
        public virtual object? Value { get; set; }
    }
}
