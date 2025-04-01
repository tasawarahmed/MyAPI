using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewStandardMark
    {
        public int ExamTypeId { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int Marks { get; set; }
        public string SubjectName { get; set; } = null!;
    }
}
