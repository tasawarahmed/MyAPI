using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblSyllabusSection
    {
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public string SyllabuSection { get; set; } = null!;
        public int? BookId { get; set; }
    }
}
