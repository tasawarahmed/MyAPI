using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenFund
    {
        public int FundsId { get; set; }
        public string FundDesc { get; set; } = null!;
        public long FundAmount { get; set; }
        public string? Remarks { get; set; }
    }
}
