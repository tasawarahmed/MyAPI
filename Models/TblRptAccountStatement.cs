using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblRptAccountStatement
    {
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
        public int ReportingOrder { get; set; }
        public int RunningBalance { get; set; }
    }
}
