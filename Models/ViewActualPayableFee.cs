using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewActualPayableFee
    {
        public string? RegistrationNumber { get; set; }
        public string Name { get; set; } = null!;
        public string Class { get; set; } = null!;
        public long ClassFee { get; set; }
        public long? Discount { get; set; }
        public long? PayableFee { get; set; }
    }
}
