using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblSyllabusProgress
    {
        public int Id { get; set; }
        public int? ClassId { get; set; }
        public string? Section { get; set; }
        public int? SubjectId { get; set; }
        public int? TermId { get; set; }
        public int? SessionId { get; set; }
        public int? SyllabusOrder { get; set; }
        public string? SyllabusItem { get; set; }
        public bool? Covered { get; set; }
    }
}
