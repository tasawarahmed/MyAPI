using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblMngtPolicy
    {
        public int Id { get; set; }
        public string? MonitoringArea { get; set; }
        public string? SubArea { get; set; }
        public string? Details { get; set; }
    }
}
