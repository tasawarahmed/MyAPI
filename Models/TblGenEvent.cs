using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenEvent
    {
        public int EventId { get; set; }
        public int SessionId { get; set; }
        public string EventName { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
