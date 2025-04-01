using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblExamSubjectsAssociationWithTeacher
    {
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public string Section { get; set; } = null!;
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
    }
}
