using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStaffOtherDeduction
    {
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }
        public int MonthId { get; set; }
        public int YearId { get; set; }
        public long DedAmount { get; set; }
        public string? Remarks { get; set; }
    }
}
