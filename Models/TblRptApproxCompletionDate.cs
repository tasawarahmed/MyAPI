using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblRptApproxCompletionDate
    {
        public int ClassId { get; set; }
        public int SubjecId { get; set; }
        public int SessionId { get; set; }
        public int TermId { get; set; }
        public int DaysAvailable { get; set; }
        public int WorkLoadDays { get; set; }
        public string Remarks { get; set; } = null!;
    }
}
