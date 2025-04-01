using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewAppointmentLetter
    {
        public string? FacultyId { get; set; }
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string? Subjective { get; set; }
        public string? Objective { get; set; }
        public string? Possessive { get; set; }
        public string? StreetAddress { get; set; }
        public string? Town { get; set; }
        public string TownName { get; set; } = null!;
        public DateTime? DateOfJoining { get; set; }
        public long? StartingSalary { get; set; }
        public bool? IsTeacher { get; set; }
        public string? Gender { get; set; }
    }
}
