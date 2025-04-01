using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherDeductionType
    {
        public int DeductionTypeId { get; set; }
        public string DeductionDesc { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
