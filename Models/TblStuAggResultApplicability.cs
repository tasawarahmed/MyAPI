using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuAggResultApplicability
    {
        public int ExamId { get; set; }
        public string ExamTypeId { get; set; } = null!;
        public int SessionId { get; set; }
        public string ExamDesc { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
