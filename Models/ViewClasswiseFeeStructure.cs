using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewClasswiseFeeStructure
    {
        public string Class { get; set; } = null!;
        public long AdmissionFee { get; set; }
        public long SecurityDeposit { get; set; }
        public long AnnualCharges { get; set; }
        public long TuitionFee { get; set; }
        public string? Remarks { get; set; }
    }
}
