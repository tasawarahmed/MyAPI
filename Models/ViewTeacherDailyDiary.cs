using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewTeacherDailyDiary
    {
        public int TermId { get; set; }
        public string ClassName { get; set; } = null!;
        public string SubjectName { get; set; } = null!;
        public string SessionDesc { get; set; } = null!;
        public string? TermName { get; set; }
        public int SyllabusOrder { get; set; }
        public string? SyllabusItem { get; set; }
        public int WorkLoadDays { get; set; }
        public string? ClassWork { get; set; }
        public string? HomeWork { get; set; }
    }
}
