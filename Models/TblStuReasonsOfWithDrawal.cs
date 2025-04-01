using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuReasonsOfWithDrawal
    {
        public int ReasonOfWithDrawalId { get; set; }
        public string WithDrawalTypeDescription { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
