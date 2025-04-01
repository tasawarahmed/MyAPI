using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblClassTeacher
    {
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public string? Section { get; set; }
    }
}
