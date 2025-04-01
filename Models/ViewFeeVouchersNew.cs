using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewFeeVouchersNew
    {
        public string? RegNum { get; set; }
        public string FatherName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string? FatherCnic { get; set; }
        public string? Address { get; set; }
        public string? Mobile { get; set; }
        public string? HomeTelephone { get; set; }
        public string? OfficeTelephone { get; set; }
        public string? Email { get; set; }
        public int VoucherId { get; set; }
        public string? FeeMonth { get; set; }
        public string? FeeYear { get; set; }
        public DateTime? DueDate { get; set; }
        public string? StudentName { get; set; }
        public string? StudentId { get; set; }
        public string? StudentClass { get; set; }
        public int? CurrentFee { get; set; }
        public int? AnnualCharges { get; set; }
        public int? TestSessionDue { get; set; }
        public int? AcchargesDue { get; set; }
        public int? Arrears { get; set; }
        public int? TotalFeeDue { get; set; }
        public string? UnpaidMonths { get; set; }
        public string? Notice1 { get; set; }
        public string? Notice2 { get; set; }
    }
}
