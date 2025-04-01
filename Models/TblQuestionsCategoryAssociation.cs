using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblQuestionsCategoryAssociation
    {
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int QuestionCategoryId { get; set; }
    }
}
