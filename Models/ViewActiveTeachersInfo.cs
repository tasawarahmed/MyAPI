using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewActiveTeachersInfo
    {
        public string? Id { get; set; }
        public int TeacherId { get; set; }
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string? Subjective { get; set; }
        public string? Objective { get; set; }
        public string? Possessive { get; set; }
        public DateTime? Dob { get; set; }
        public string? Cnic { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Ptcl { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactNumber { get; set; }
        public string? Address { get; set; }
        public string? Town { get; set; }
        public string TownName { get; set; } = null!;
        public string? Qualification { get; set; }
        public string? Institute { get; set; }
        public string? Educational { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public long? Salary { get; set; }
        public DateTime? LastIncrementDate { get; set; }
        public long? CurrentGrossSalary { get; set; }
        public string? RemarksAtJoining { get; set; }
        public DateTime? DateOfTermination { get; set; }
        public int? ReasonOfTermination { get; set; }
        public string? RemarksAtTermination { get; set; }
        public bool? IsTeacher { get; set; }
    }
}
