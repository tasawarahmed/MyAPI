using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuSyllabusBook
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public string Bookname { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
