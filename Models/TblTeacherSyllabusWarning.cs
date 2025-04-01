using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherSyllabusWarning
    {
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }
        public int? WarningDescription { get; set; }
        public int CashFine { get; set; }
        public string? FurtherInstructions { get; set; }
    }
}
