using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenOccupation
    {
        public int OccupationId { get; set; }
        public string OccupationDesc { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
