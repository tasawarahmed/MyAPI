using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblFeeInstallment
    {
        public int Id { get; set; }
        public int StuId { get; set; }
        public int InstallmentCount { get; set; }
        public int InstallmentAmount { get; set; }
        public DateTime InstallmentDate { get; set; }
        public string? Remarks { get; set; }
    }
}
