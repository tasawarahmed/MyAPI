using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewOldStaff
    {
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string? PrimaryQualification { get; set; }
        public string? EducationalQualification { get; set; }
        public string? Address { get; set; }
        public string? MobileNumber { get; set; }
        public string? Ptcl { get; set; }
        public string? Email { get; set; }
        public string TownName { get; set; } = null!;
    }
}
