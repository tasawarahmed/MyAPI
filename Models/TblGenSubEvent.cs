using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenSubEvent
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string SubEventName { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
