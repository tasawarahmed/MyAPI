using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblMngtDocument
    {
        public int Id { get; set; }
        public string? DocumentName { get; set; }
        public string? Details { get; set; }
    }
}
