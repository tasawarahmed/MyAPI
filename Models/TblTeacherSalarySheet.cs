using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherSalarySheet
    {
        public int TeacherId { get; set; }
        public int SalaryMonth { get; set; }
        public int SalaryYear { get; set; }
        public long BasicSalary { get; set; }
        public long? Allowances { get; set; }
        public long? AdvanceSalaryAdjustments { get; set; }
        public long? LeaveDeductions { get; set; }
        public long? TaxDeductions { get; set; }
        public long? OtherDeductions { get; set; }
        public long? NetSalary { get; set; }
        public int? Lates { get; set; }
        public int? ShortLeaves { get; set; }
        public int? Absents { get; set; }
        public int? EmergencyLeaves { get; set; }
        public int? LeavesDeducted { get; set; }
        public int? AlreadyAvailedLeaves { get; set; }
        public string? Words { get; set; }
        public string? Remarks { get; set; }
    }
}
