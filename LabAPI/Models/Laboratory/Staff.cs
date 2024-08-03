using LabAPI.Models.Reference;

namespace LabAPI.Models.Laboratory
{
    public class Staff
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public StaffQualification? Qualification { get; set; }
        public required IAM.User User { get; set; }
        public required MedicalCenter MedicalCenter { get; set; }
    }
}
