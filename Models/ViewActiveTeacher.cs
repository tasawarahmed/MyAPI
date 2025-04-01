using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewActiveTeacher
    {
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string? PrimaryQualification { get; set; }
        public DateTime? LastIncrement { get; set; }
        public long? CurrentSalary { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfJoining { get; set; }
    }
}
