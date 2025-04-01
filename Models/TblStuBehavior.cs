using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuBehavior
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public long StuId { get; set; }
        public int StuBehId { get; set; }
        public string? Remarks { get; set; }
    }
}
