using LabAPI.Models.Dictionary;

namespace LabAPI.Models.Organization;

public record ServicePrice(Service Service, DateOnly Issued, double Cost);