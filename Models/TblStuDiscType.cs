using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuDiscType
    {
        public int StuDiscId { get; set; }
        public string StuDiscDesc { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
