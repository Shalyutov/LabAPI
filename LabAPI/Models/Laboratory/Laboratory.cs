﻿namespace LabAPI.Models.Laboratory
{
    public class Laboratory
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; }
        public int Level { get; set; }
    }
}
