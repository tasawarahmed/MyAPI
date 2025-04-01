using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblRptStudentPaymentHistory
    {
        public int StuId { get; set; }
        public DateTime Date { get; set; }
        public int FeeTypeId { get; set; }
        public int MonthId { get; set; }
        public int Year { get; set; }
        public int Amount { get; set; }
    }
}
