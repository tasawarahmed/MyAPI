using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuEventStanding
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int EventId { get; set; }
        public int SubEventId { get; set; }
        public int PrizeId { get; set; }
        public string? Remarks { get; set; }
    }
}
