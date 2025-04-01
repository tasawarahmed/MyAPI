using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblHifzEnrollemnt
    {
        public int Id { get; set; }
        public int StuId { get; set; }
        public int? StuStatus { get; set; }
        public DateTime? DateOfEnrollment { get; set; }
        public DateTime? DateOfWithdrawal { get; set; }
        public string? Remarks { get; set; }
    }
}
