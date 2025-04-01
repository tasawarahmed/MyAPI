using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewTrialBalance
    {
        public int AccountTypeId { get; set; }
        public DateTime Date { get; set; }
        public string AccountName { get; set; } = null!;
        public string AccountTypeName { get; set; } = null!;
        public int Debit { get; set; }
        public int Credit { get; set; }
    }
}
