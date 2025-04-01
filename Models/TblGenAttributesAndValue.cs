using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenAttributesAndValue
    {
        public string AttName { get; set; } = null!;
        public string? AttValue { get; set; }
        public string? Remarks { get; set; }
    }
}
