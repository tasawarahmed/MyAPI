using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblMngtStaffDevelopment
    {
        public int Id { get; set; }
        public string? Topic { get; set; }
        public string? Details { get; set; }
        public string? Remarks { get; set; }
    }
}
