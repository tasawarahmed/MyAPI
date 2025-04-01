using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherAllowance
    {
        public int TeacherId { get; set; }
        public int MonthId { get; set; }
        public int YearId { get; set; }
        public int Amount { get; set; }
        public string? Remarks { get; set; }
    }
}
