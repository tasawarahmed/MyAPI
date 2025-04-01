using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblAccType
    {
        public int AccountTypeId { get; set; }
        public string AccountTypeName { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
