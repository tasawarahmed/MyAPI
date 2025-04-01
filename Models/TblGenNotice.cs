using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenNotice
    {
        public int NoticeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DueDate { get; set; }
        public string Description { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
