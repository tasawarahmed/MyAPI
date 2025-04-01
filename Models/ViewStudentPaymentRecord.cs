using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewStudentPaymentRecord
    {
        public string? StuRegNumber { get; set; }
        public long StuId { get; set; }
        public string StuName { get; set; } = null!;
        public DateTime? Date { get; set; }
        public string FeeTypeDesc { get; set; } = null!;
        public string MonthName { get; set; } = null!;
        public int? Year { get; set; }
        public long? FeePaid { get; set; }
        public long? FundAmount { get; set; }
        public string? Remarks { get; set; }
    }
}
