﻿namespace LabAPI.Models.Dictionary
{
    public class Service
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public string? ShortName { get; set; }
    }
}
