using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenClass
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
