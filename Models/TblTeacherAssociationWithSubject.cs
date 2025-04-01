using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherAssociationWithSubject
    {
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
    }
}
