using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblBmpabc
    {
        public int Id { get; set; }
        public int StuId { get; set; }
        public DateTime Date { get; set; }
        public string? Antecedent { get; set; }
        public string? Behavior { get; set; }
        public string? Consequence { get; set; }
    }
}
