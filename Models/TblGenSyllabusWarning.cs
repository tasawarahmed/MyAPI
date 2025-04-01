using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenSyllabusWarning
    {
        public int SyllabusWarningId { get; set; }
        public string WarningDescription { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
