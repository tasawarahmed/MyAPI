using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherDuty
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int? AssignedBy { get; set; }
        public DateTime? DateOfAssignment { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Details { get; set; }
        public string? TeacherFeedBack { get; set; }
        public string? Remarks { get; set; }
    }
}
