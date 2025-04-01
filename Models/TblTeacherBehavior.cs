using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherBehavior
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }
        public int BehaviorId { get; set; }
        public string? Remarks { get; set; }
    }
}
