using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuAggResult
    {
        public int AggResultId { get; set; }
        public string AggResultName { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
