using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherAttendance
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }
        public bool? IsEmergencyLeave { get; set; }
        public bool? IsAbsent { get; set; }
        public bool? IsLate { get; set; }
        public bool? ShortLeave { get; set; }
        public bool? ApplicationReceived { get; set; }
        public int? ReasonOfLeave { get; set; }
        public string? Remarks { get; set; }
        public bool? IsHalfDay { get; set; }
    }
}
