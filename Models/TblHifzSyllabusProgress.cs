using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblHifzSyllabusProgress
    {
        public int Id { get; set; }
        public int StuId { get; set; }
        public int? AyahCount { get; set; }
        public DateTime? AyahDoneOn { get; set; }
        public int? SurahCount { get; set; }
        public DateTime? SurahStartedOn { get; set; }
        public DateTime? SurahDoneOn { get; set; }
        public int? ParaCount { get; set; }
        public DateTime? ParaStartedOn { get; set; }
        public DateTime? ParaDoneOn { get; set; }
    }
}
