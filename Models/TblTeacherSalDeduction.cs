using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherSalDeduction
    {
        public int TeacherId { get; set; }
        public int DeductionTypeId { get; set; }
        public int MonthId { get; set; }
        public int YearId { get; set; }
        public long Amount { get; set; }
        public string? Remarks { get; set; }
    }
}
