using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewTeacherAttendance
    {
        public DateTime Date { get; set; }
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public bool? EmergencyLeave { get; set; }
        public bool? Absent { get; set; }
        public bool? Late { get; set; }
        public bool? ShortLeave { get; set; }
        public bool? LeaveApplication { get; set; }
        public string ReasonOfLeave { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
