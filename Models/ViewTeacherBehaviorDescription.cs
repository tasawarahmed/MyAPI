using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewTeacherBehaviorDescription
    {
        public DateTime Date { get; set; }
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string BehaviorDescription { get; set; } = null!;
    }
}
