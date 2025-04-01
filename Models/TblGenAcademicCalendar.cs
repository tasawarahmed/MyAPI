using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenAcademicCalendar
    {
        public int SessionId { get; set; }
        public DateTime Date { get; set; }
        public string? Day { get; set; }
        public string? Status { get; set; }
        public string? Term { get; set; }
        public string? StudentDev { get; set; }
        public string? TeacherDev { get; set; }
    }
}
