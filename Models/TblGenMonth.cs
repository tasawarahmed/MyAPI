using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenMonth
    {
        public int MonthId { get; set; }
        public string MonthName { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
