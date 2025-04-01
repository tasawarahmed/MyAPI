using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewAccountStatement
    {
        public int AccountTypeId { get; set; }
        public string AccountName { get; set; } = null!;
        public string AccountTypeName { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
        public int ReportingOrder { get; set; }
        public int RunningBalance { get; set; }
    }
}
