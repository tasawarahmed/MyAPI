using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblQuestionsBank
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int QuestionCategoryId { get; set; }
        public string ChapterDescription { get; set; } = null!;
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public int? BookId { get; set; }
    }
}
