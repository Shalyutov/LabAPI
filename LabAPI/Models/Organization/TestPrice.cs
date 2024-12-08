using LabAPI.Models.Dictionary;

namespace LabAPI.Models.Organization;

public record TestPrice(Test Test, DateOnly Issued, double Cost);