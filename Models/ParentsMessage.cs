using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ParentsMessage
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? StuId { get; set; }
        public int? TeacherId { get; set; }
        public string? Message { get; set; }
        public string? Reply { get; set; }
        public bool? IsReplied { get; set; }
        public string? Remarks { get; set; }
    }
}
