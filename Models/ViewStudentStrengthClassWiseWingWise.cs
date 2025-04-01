using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewStudentStrengthClassWiseWingWise
    {
        public int? NumberOfStudents { get; set; }
        public string ClassName { get; set; } = null!;
        public string WingDesc { get; set; } = null!;
    }
}
