using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewFeeVoucher
    {
        public string? StudentId { get; set; }
        public string? StuRegNumber { get; set; }
        public int FeeVoucherId { get; set; }
        public string? FeeMonth { get; set; }
        public string? FeeYear { get; set; }
        public DateTime? DueDate { get; set; }
        public string? StudentName { get; set; }
        public string? StudentClass { get; set; }
        public int? CurrentFeeDue { get; set; }
        public int? AnnualChargesDue { get; set; }
        public int? TotalFeeDue { get; set; }
        public string? FeeUnpaidMonths { get; set; }
        public string? FeeNotice { get; set; }
        public string? OtherNotices { get; set; }
        public string StuFatherName { get; set; } = null!;
        public DateTime? StuDob { get; set; }
        public string? StuFatherCnic { get; set; }
        public string? StuHomeStreet { get; set; }
        public string? StuFatherMobile { get; set; }
        public string? StuHomeTelNo { get; set; }
        public string? StuOfficeTelNo { get; set; }
        public string? StuEmail { get; set; }
        public int? ArrearsOfFee { get; set; }
    }
}
