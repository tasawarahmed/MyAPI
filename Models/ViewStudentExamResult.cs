using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewStudentExamResult
    {
        public long StuId { get; set; }
        public string StuName { get; set; } = null!;
        public string SubjectName { get; set; } = null!;
        public int ExamId { get; set; }
        public int? ClassId { get; set; }
        public string? Section { get; set; }
        public int? StdMarks { get; set; }
        public int? ActualMarks { get; set; }
        public double MarksObtained { get; set; }
        public double? StdMarksObtained { get; set; }
        public string? Remarks { get; set; }
        public string? StuGender { get; set; }
        public string ClassName { get; set; } = null!;
        public string ExamDescription { get; set; } = null!;
    }
}
