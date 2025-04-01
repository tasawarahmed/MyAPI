using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewAccountStatement1
    {
        public DateTime Date { get; set; }
        public string? Details { get; set; }
        public long? Debit { get; set; }
        public long? Credit { get; set; }
        public int AccountId { get; set; }
    }
}
