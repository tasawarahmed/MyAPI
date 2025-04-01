using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenBool
    {
        public int BoolId { get; set; }
        public string BoolDescription { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
