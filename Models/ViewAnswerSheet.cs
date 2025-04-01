using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewAnswerSheet
    {
        public int ExamId { get; set; }
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int WingId { get; set; }
        public int TeacherId { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime? DateReceived { get; set; }
        public string Name { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public string WingDesc { get; set; } = null!;
        public string ExamDescription { get; set; } = null!;
        public string SubjectName { get; set; } = null!;
    }
}
