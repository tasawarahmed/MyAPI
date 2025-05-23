﻿using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewSyllabusProgress
    {
        public string SubjectName { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public int? TotalDaysAvailable { get; set; }
        public int? TotalWorkLoad { get; set; }
        public int? TotalDaysPassed { get; set; }
        public int? BwloadCovered { get; set; }
        public int? GwloadCovered { get; set; }
        public string? Bwstatus { get; set; }
        public string? Gwstatus { get; set; }
    }
}
