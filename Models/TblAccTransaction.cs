using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblAccTransaction
    {
        public long TransactionId { get; set; }
        public int AccountId { get; set; }
        public DateTime Date { get; set; }
        public long? DebitAmount { get; set; }
        public long? CreditAmount { get; set; }
        public string? TransactionDesc { get; set; }
        public string? Remarks { get; set; }
    }
}
