using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewActualCashReceiving
    {
        public long Id { get; set; }
        public string? RegistrationNumber { get; set; }
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string Class { get; set; } = null!;
        public long TuitionFee { get; set; }
        public long? Discount { get; set; }
        public long? CashFee { get; set; }
    }
}
