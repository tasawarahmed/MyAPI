using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenAdvType
    {
        public int AdvTypeId { get; set; }
        public string AdvTypeDesc { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
