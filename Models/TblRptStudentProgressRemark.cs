using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblRptStudentProgressRemark
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int Total { get; set; }
        public int Slot1 { get; set; }
        public int Slot2 { get; set; }
        public int Slot3 { get; set; }
        public string Remarks { get; set; } = null!;
    }
}
