using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuSubjectAssociationWithClass
    {
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public int PeriodsPerWeek { get; set; }
        public string? Remarks { get; set; }
    }
}
