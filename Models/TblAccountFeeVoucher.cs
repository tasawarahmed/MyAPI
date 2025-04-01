using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblAccountFeeVoucher
    {
        public int FeeVoucherId { get; set; }
        public string? FeeMonth { get; set; }
        public string? FeeYear { get; set; }
        public DateTime? DueDate { get; set; }
        public string? StudentName { get; set; }
        public string? StudentId { get; set; }
        public string? StudentClass { get; set; }
        public int? CurrentFeeDue { get; set; }
        public int? AnnualChargesDue { get; set; }
        public int? ArrearsOfFee { get; set; }
        public int? TotalFeeDue { get; set; }
        public string? FeeUnpaidMonths { get; set; }
        public string? FeeNotice { get; set; }
        public string? OtherNotices { get; set; }
    }
}
