using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblHifzSyllabus
    {
        public int? RanningAyah { get; set; }
        public string? AyahText { get; set; }
        public int? SurahCount { get; set; }
        public string? SurahName { get; set; }
        public int? SurahAyah { get; set; }
        public int? ParaCount { get; set; }
        public string? ParaName { get; set; }
        public int? Pao { get; set; }
        public int? ManzilCount { get; set; }
    }
}
