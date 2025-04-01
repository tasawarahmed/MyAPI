using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenTerm
    {
        public int TermId { get; set; }
        public string? TermName { get; set; }
        public string? Remarks { get; set; }
    }
}
