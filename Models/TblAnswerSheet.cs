using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblAnswerSheet
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int WingId { get; set; }
        public int TeacherId { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime? DateReceived { get; set; }
        public bool ReceivedBack { get; set; }
        public string? Section { get; set; }
    }
}
