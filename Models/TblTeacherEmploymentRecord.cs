using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherEmploymentRecord
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public DateTime? DateOfTermination { get; set; }
        public int? ReasonOfTermination { get; set; }
        public string? Remarks { get; set; }
    }
}
