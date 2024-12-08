using LabAPI.Models.Dictionary;
using LabAPI.Models.Laboratory;

namespace LabAPI.Models.Organization;

public record SupplyAccountRecord(Supply Supply, int Value, DateTime Issued, MedicalCenter MedicalCenter);