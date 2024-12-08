namespace LabAPI.Models.Dictionary
{
    public class Indicator
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public string? ShortName { get; set; }
        public string? Comment { get; set; }
        public required Test Test { get; set; }
        
        public Measure? Measure { get; set; }
        public double? Low { get; set; }
        public double? High { get; set; }
        public bool? Reference { get; set; }
        public Indicator(int id, string fullName, string? shortName, string? comment, Test test, Measure measure, double low, double high)
        {
            Id = id;
            FullName = fullName;
            ShortName = shortName;
            Comment = comment;
            Test = test;
            
            Measure = measure;
            Low = low;
            High = high;
        }
        public Indicator(int id, string fullName, string? shortName, string? comment, Test test, bool reference)
        {
            Id = id;
            FullName = fullName;
            ShortName = shortName;
            Comment = comment;
            Test = test;
            
            Reference = reference;
        }
    }

}
