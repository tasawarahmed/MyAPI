using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewBehavioralIssue
    {
        public int? PertainsTo { get; set; }
        public int BehIssueId { get; set; }
        public string BehIssueDesc { get; set; } = null!;
        public string? Remarks { get; set; }
        public string EntityDesc { get; set; } = null!;
    }
}
