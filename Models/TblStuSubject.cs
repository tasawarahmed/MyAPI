using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuSubject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = null!;
        public string? SubjectDesc { get; set; }
        public string? SubjectRemarks { get; set; }
    }
}
