namespace LabAPI.Models.Reference
{
    public class Indicator(int id, string fullName, string? shortName, string? comment, Test test)
    {
        public int Id { get; set; } = id;
        public required string FullName { get; set; } = fullName;
        public string? ShortName { get; set; } = shortName;
        public string? Comment { get; set; } = comment;
        public required Test Test { get; set; } = test;
    }
    public class IntegerIndicator(int id, string fullName, string? shortName, string? comment, Test test, Measure measure, double low, double high) : Indicator(id, fullName, shortName, comment, test) 
    {
        public required Measure Measure { get; set; } = measure;
        public double Low { get; set; } = low;
        public double High { get; set; } = high;
    }
    public class BinaryIndicator(int id, string fullName, string? shortName, string? comment, Test test, bool reference) : Indicator(id, fullName, shortName, comment, test)
    {
        public bool Measure { get; set; } = reference;
    }
    public class TextIndicator(int id, string fullName, string? shortName, string? comment, Test test, string reference) : Indicator(id, fullName, shortName, comment, test)
    {
        public string? Text { get; set; } = reference;
    }
}
