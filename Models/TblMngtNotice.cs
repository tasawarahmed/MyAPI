using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblMngtNotice
    {
        public int Id { get; set; }
        public string? Topic { get; set; }
        public string? Details { get; set; }
    }
}
