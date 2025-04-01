using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblMngtSop
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Target { get; set; }
        public string? Details { get; set; }
    }
}
