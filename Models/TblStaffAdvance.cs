using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStaffAdvance
    {
        public int StaffId { get; set; }
        public int AdvTypeId { get; set; }
        public DateTime DateAdvTaken { get; set; }
        public int MonthId { get; set; }
        public int YearId { get; set; }
        public long Amount { get; set; }
        public string? Remarks { get; set; }
    }
}
