using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblInventoryTransaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public int ItemId { get; set; }
        public int ItemLocation { get; set; }
        public string? Description { get; set; }
        public int ReceiptQuantity { get; set; }
        public int IssueQuantity { get; set; }
        public int Amount { get; set; }
    }
}
