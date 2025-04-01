using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenBehIssue
    {
        public int BehIssueId { get; set; }
        public int? PertainsTo { get; set; }
        public string BehIssueDesc { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
