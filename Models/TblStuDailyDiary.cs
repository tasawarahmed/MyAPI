using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuDailyDiary
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; } = null!;
        public string? Task { get; set; }
    }
}
