using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewStudentsAttendance
    {
        public DateTime Date { get; set; }
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string Class { get; set; } = null!;
        public string Wing { get; set; } = null!;
        public bool Absent { get; set; }
        public bool Late { get; set; }
        public bool PartialLeave { get; set; }
        public bool? LeaveApplication { get; set; }
        public string ReasonOfLeave { get; set; } = null!;
        public long StuId { get; set; }
    }
}
