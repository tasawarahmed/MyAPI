using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenAnnouncement
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Message { get; set; }
    }
}
