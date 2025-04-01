using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblSyllabusBreakup
    {
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int TermId { get; set; }
        public int SessionId { get; set; }
        public int SyllabusOrder { get; set; }
        public string? SyllabusItem { get; set; }
        public int WorkLoadDays { get; set; }
        public bool GirlsWing { get; set; }
        public bool BoysWing { get; set; }
        public string? ClassWork { get; set; }
        public string? HomeWork { get; set; }
        public string? Remarks { get; set; }
    }
}
