using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblRptDatesheet
    {
        public int ExamId { get; set; }
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public DateTime? Date { get; set; }
        public string? Syllabus { get; set; }
    }
}
