using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewStudent
    {
        public long StuId { get; set; }
        public string StuName { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public string? StuFatherCnic { get; set; }
    }
}
