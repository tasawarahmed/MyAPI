using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewBankStatement
    {
        public DateTime Date { get; set; }
        public string? Details { get; set; }
        public long? Debit { get; set; }
        public long? Credit { get; set; }
    }
}
