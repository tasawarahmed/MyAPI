using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenParticular
    {
        public int Id { get; set; }
        public string? EmailAddress { get; set; }
        public string? Website { get; set; }
        public string? Phone { get; set; }
        public string? Contact { get; set; }
        public byte[]? Photo { get; set; }
    }
}
