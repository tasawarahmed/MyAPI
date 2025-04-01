using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuExamType
    {
        public int ExamTypeId { get; set; }
        public string ExamTypeDesc { get; set; } = null!;
        public string? ExamTypeRemarks { get; set; }
    }
}
