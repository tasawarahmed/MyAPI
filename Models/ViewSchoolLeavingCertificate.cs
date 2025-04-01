using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewSchoolLeavingCertificate
    {
        public long StuId { get; set; }
        public string? StuRegNumber { get; set; }
        public string StuName { get; set; } = null!;
        public string StuFatherName { get; set; } = null!;
        public DateTime? StuDob { get; set; }
        public string? StuGender { get; set; }
        public DateTime? StuAdmDate { get; set; }
        public string ClassName { get; set; } = null!;
        public DateTime? StuWithDrawalDate { get; set; }
    }
}
