using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblSubjectStandardMark
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public int Class { get; set; }
        public int Monthly { get; set; }
        public int Term { get; set; }
        public int Series { get; set; }
        public int Aggregate { get; set; }
        public string? Remarks { get; set; }
    }
}
