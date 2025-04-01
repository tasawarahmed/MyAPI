using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenReligion
    {
        public int Id { get; set; }
        public string ReligionName { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
