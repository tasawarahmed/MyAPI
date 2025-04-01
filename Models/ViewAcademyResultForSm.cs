using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewAcademyResultForSm
    {
        public string StuName { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public int? TotalMarks { get; set; }
        public int? TotalSlot1 { get; set; }
        public string? StuFatherMobile { get; set; }
    }
}
