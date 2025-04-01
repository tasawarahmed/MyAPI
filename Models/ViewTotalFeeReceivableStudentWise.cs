using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewTotalFeeReceivableStudentWise
    {
        public long? TotalFeeDue { get; set; }
        public string StuName { get; set; } = null!;
        public string? StuRegNumber { get; set; }
        public string ClassName { get; set; } = null!;
        public int? StuCurrentWing { get; set; }
    }
}
