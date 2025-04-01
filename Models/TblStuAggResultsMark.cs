using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuAggResultsMark
    {
        public int AggResultId { get; set; }
        public long StuId { get; set; }
        public int SubjectId { get; set; }
        public int TotalMarks { get; set; }
        public int ObtainedMarks { get; set; }
        public string? Remarks { get; set; }
    }
}
