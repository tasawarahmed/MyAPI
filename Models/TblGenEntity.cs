using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenEntity
    {
        public int EntityId { get; set; }
        public string EntityDesc { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
