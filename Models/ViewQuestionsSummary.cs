using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewQuestionsSummary
    {
        public string ClassName { get; set; } = null!;
        public string SubjectName { get; set; } = null!;
        public string ChapterDescription { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int? NumberOfQuestions { get; set; }
    }
}
