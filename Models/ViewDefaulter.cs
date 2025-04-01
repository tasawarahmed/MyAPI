using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewDefaulter
    {
        public string? StuRegNumber { get; set; }
        public string StuName { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public string WingDesc { get; set; } = null!;
        public string MonthName { get; set; } = null!;
        public int? Year { get; set; }
        public long? FeeDue { get; set; }
        public long? FeePaid { get; set; }
        public long? FeeUnpaid { get; set; }
        public string FeeTypeDesc { get; set; } = null!;
        public int? FeeMonthId { get; set; }
    }
}
