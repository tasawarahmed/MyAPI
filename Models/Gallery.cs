using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class Gallery
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Event { get; set; }
        public string? Link { get; set; }
        public string? Remarks { get; set; }
    }
}
