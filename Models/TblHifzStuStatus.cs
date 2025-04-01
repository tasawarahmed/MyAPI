using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblHifzStuStatus
    {
        public int Id { get; set; }
        public int StuId { get; set; }
        public string? SabaqQuantity { get; set; }
        public string? ManzilSituation { get; set; }
        public string? Remarks { get; set; }
    }
}
