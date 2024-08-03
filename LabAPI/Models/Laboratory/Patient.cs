namespace LabAPI.Models.Laboratory
{
    public enum Gender
    {
        Male, Female
    }
    public enum DocumentType
    {
        Passport, DriverLicense
    }
    public enum InsuranceType
    {
        OMS, DMS
    }
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string RepresentativeName { get; set; }
        public Gender Gender { get; set; }
        public DateOnly Birth { get; set; }
        public string AddressActual { get; set; }
        public string AddressFact { get; set; }
        public DocumentType Document { get; set; }
        public Int64 DocumentNumber { get; set; }
        public string DocumentIssuer { get; set; }
        public DateOnly DocumentIssued { get; set; }
        public Int64 Phone {  get; set; }
        public string Email { get; set; }
        public InsuranceType Insurance { get; set; }
        public Int64 InsuranceNumber { get; set; }
        public string InsuranceIssuer { get; set; }
    }
}
