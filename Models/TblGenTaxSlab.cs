using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenTaxSlab
    {
        public long? LowerLimit { get; set; }
        public long? UpperLimit { get; set; }
        public double? Rate { get; set; }
    }
}
