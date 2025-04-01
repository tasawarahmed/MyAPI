using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenReasonsOfLeave
    {
        public int ReasonOfLeaveId { get; set; }
        public string ReasonOfLeaveDesc { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
