using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewAdmissionSlip
    {
        public string StuName { get; set; } = null!;
        public string? StuRegNumber { get; set; }
        public string ClassName { get; set; } = null!;
        public DateTime? StuAdmDate { get; set; }
        public string StuFatherName { get; set; } = null!;
        public string? StuFatherMobile { get; set; }
        public string? StuHomeTelNo { get; set; }
        public string? StuOfficeTelNo { get; set; }
    }
}
