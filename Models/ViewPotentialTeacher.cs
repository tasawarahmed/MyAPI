using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewPotentialTeacher
    {
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string? Address { get; set; }
        public string Town { get; set; } = null!;
        public string? MobileNumber { get; set; }
        public string? Ptcl { get; set; }
        public string? Email { get; set; }
        public string PrimarySubject { get; set; } = null!;
        public string? RemarksAtJoining { get; set; }
        public string SecondarySubject { get; set; } = null!;
        public int? PrimarySubject1 { get; set; }
        public int? SecondarySubject1 { get; set; }
    }
}
