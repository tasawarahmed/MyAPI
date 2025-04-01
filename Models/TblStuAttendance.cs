using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuAttendance
    {
        public int Id { get; set; }
        public long StuId { get; set; }
        public DateTime Date { get; set; }
        public bool IsAbsent { get; set; }
        public bool IsLate { get; set; }
        public bool PartialLeave { get; set; }
        public bool? LeaveAppRec { get; set; }
        public int? ReasonOfLeave { get; set; }
        public string? Remarks { get; set; }
    }
}
