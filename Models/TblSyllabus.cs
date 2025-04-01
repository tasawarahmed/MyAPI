using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblSyllabus
    {
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public string? Syllabus { get; set; }
        public string? Remarks { get; set; }
    }
}
