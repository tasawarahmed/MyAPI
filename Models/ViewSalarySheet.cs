using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewSalarySheet
    {
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public int SalaryYear { get; set; }
        public long BasicSalary { get; set; }
        public long? Allowances { get; set; }
        public long? AdvanceSalary { get; set; }
        public long? LeaveDeductions { get; set; }
        public long? TaxDeductions { get; set; }
        public long? OtherDeductions { get; set; }
        public string? Remarks { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string? FacultyId { get; set; }
        public int TeacherId { get; set; }
        public long? NetSalary { get; set; }
        public string? ShortName { get; set; }
        public int? Lates { get; set; }
        public int? ShortLeaves { get; set; }
        public int? Absents { get; set; }
        public int? EmergencyLeaves { get; set; }
        public int? LeavesDeducted { get; set; }
        public int? AlreadyAvailedLeaves { get; set; }
        public string? Words { get; set; }
    }
}
