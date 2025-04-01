using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewTotalWithdrawal
    {
        public DateTime? DateOfWithdrawal { get; set; }
        public string Name { get; set; } = null!;
        public string FatherSName { get; set; } = null!;
        public string Class { get; set; } = null!;
        public string Wing { get; set; } = null!;
    }
}
