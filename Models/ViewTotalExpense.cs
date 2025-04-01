using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewTotalExpense
    {
        public DateTime Date { get; set; }
        public string NameOfAccount { get; set; } = null!;
        public long? Debit { get; set; }
        public long? Credit { get; set; }
        public string? Details { get; set; }
    }
}
