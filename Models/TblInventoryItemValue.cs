using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblInventoryItemValue
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ItemId { get; set; }
        public int CostValue { get; set; }
        public int MarketValue { get; set; }
    }
}
