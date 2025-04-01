using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuClasswiseFeeDetail
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public long TuitionFee { get; set; }
        public long AdmissionFee { get; set; }
        public long SecurityDeposits { get; set; }
        public long AnnualCharges { get; set; }
        public string? Remarks { get; set; }
    }
}
