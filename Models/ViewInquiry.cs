using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewInquiry
    {
        public string ClassName { get; set; } = null!;
        public string TownName { get; set; } = null!;
        public DateTime DateOfInquiry { get; set; }
        public string StuName { get; set; } = null!;
        public string StuFatherName { get; set; } = null!;
        public string? StAddress { get; set; }
        public string? ContactNumber { get; set; }
        public long TuitionFee { get; set; }
        public long AdmissionFee { get; set; }
        public long SecurityDeposits { get; set; }
        public long AnnualCharges { get; set; }
        public int StuInqId { get; set; }
    }
}
