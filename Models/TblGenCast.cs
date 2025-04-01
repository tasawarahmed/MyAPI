using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenCast
    {
        public int CastId { get; set; }
        public string CastName { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
