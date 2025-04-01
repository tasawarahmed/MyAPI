using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblExamGrade
    {
        public int Id { get; set; }
        public string? GradeLetter { get; set; }
        public int? LowerLimit { get; set; }
        public string? Remarks { get; set; }
    }
}
