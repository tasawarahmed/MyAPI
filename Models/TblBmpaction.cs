using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblBmpaction
    {
        public int Id { get; set; }
        public int StuId { get; set; }
        public DateTime Date { get; set; }
        public string? Action { get; set; }
        public string? Result { get; set; }
    }
}
