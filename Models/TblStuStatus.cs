using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuStatus
    {
        public int StuStatusId { get; set; }
        public string StuStatusDesc { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
