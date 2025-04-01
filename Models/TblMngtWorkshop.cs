using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblMngtWorkshop
    {
        public int Id { get; set; }
        public string? Organizer { get; set; }
        public string? Topic { get; set; }
        public string? Details { get; set; }
    }
}
