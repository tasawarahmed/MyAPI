using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuUnpaidFeeStatus
    {
        public long StuId { get; set; }
        public int FeeTypeId { get; set; }
        public int MonthId { get; set; }
        public int Year { get; set; }
        public long Amount { get; set; }
        public string? Remarks { get; set; }
    }
}
