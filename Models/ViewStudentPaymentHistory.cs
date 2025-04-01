using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewStudentPaymentHistory
    {
        public int StuId { get; set; }
        public string? StuRegNumber { get; set; }
        public string StuName { get; set; } = null!;
        public DateTime Date { get; set; }
        public string FeeTypeDesc { get; set; } = null!;
        public int MonthId { get; set; }
        public string MonthName { get; set; } = null!;
        public int Year { get; set; }
        public int Amount { get; set; }
    }
}
