using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewAdvanceFeeCollected
    {
        public string StuName { get; set; } = null!;
        public string? StuRegNumber { get; set; }
        public string FeeTypeDesc { get; set; } = null!;
        public int FeePaid { get; set; }
        public DateTime Date { get; set; }
        public string MonthName { get; set; } = null!;
        public int Year { get; set; }
    }
}
