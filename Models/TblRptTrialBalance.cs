using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblRptTrialBalance
    {
        public DateTime Date { get; set; }
        public int AccountId { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
    }
}
