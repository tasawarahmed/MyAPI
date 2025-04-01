using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuExamAssociationWithSubject
    {
        public int ExamId { get; set; }
        public int SubjectId { get; set; }
        public string? Remarks { get; set; }
    }
}
