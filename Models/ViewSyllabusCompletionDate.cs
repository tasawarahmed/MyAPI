using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewSyllabusCompletionDate
    {
        public string ClassName { get; set; } = null!;
        public string SubjectName { get; set; } = null!;
        public string? TermName { get; set; }
        public string SessionDesc { get; set; } = null!;
        public int DaysAvailable { get; set; }
        public int WorkLoadDays { get; set; }
        public string Remarks { get; set; } = null!;
    }
}
