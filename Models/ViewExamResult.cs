using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewExamResult
    {
        public long StuId { get; set; }
        public string StuName { get; set; } = null!;
        public string SubjectName { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public int SubjectId { get; set; }
        public int ExamId { get; set; }
        public int? ClassId { get; set; }
        public string? Section { get; set; }
        public int? ActualMarks { get; set; }
        public double MarksObtained { get; set; }
    }
}
