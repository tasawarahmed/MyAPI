using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenTown
    {
        public int TownId { get; set; }
        public string TownName { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
