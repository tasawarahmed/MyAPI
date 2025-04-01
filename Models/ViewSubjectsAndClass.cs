using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewSubjectsAndClass
    {
        public string ClassName { get; set; } = null!;
        public string SubjectName { get; set; } = null!;
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
    }
}
