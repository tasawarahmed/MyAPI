using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblQuestionPaper
    {
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public string ExamName { get; set; } = null!;
        public string? Question { get; set; }
        public string? Answer { get; set; }
    }
}
