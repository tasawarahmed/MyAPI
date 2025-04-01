using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuFeeAdvance
    {
        public int I { get; set; }
        public DateTime Date { get; set; }
        public int StuId { get; set; }
        public int FeeTypeId { get; set; }
        public int FeeMonthId { get; set; }
        public int Year { get; set; }
        public int FeePaid { get; set; }
        public int FundAmount { get; set; }
        public string? Status { get; set; }
        public string? Remarks { get; set; }
        public string? FeeCollector { get; set; }
    }
}
