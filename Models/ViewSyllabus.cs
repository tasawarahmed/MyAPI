using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewSyllabus
    {
        public string ClassName { get; set; } = null!;
        public string SubjectName { get; set; } = null!;
        public string? Syllabus { get; set; }
    }
}
