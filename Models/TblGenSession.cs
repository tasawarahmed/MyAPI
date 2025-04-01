using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenSession
    {
        public int SessionId { get; set; }
        public string SessionDesc { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
