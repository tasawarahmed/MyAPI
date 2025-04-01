using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuAggResultWeight
    {
        public int AggResultId { get; set; }
        public int ExamId { get; set; }
        public decimal Weight { get; set; }
        public string? Remarks { get; set; }
    }
}
