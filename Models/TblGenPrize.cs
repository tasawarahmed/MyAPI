using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenPrize
    {
        public int PrizeId { get; set; }
        public int CategoryId { get; set; }
        public string NameofPrize { get; set; } = null!;
    }
}
