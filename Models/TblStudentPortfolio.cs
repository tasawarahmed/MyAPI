using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStudentPortfolio
    {
        public int Id { get; set; }
        public int StuId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; } = null!;
    }
}
