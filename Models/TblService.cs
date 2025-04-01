using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblService
    {
        public int Id { get; set; }
        public string? ServiceName { get; set; }
        public string? Scope { get; set; }
        public string? FeeTypeName { get; set; }
        public string? FeeTypeShortName { get; set; }
    }
}
