using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblAccTransactionsTemp
    {
        public int AccountId { get; set; }
        public int ControlField { get; set; }
        public DateTime Date { get; set; }
        public int DebitAmount { get; set; }
        public int CreditAmount { get; set; }
        public string? TransactionDesc { get; set; }
        public string? Remarks { get; set; }
    }
}
