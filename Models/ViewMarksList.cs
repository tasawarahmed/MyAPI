using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewMarksList
    {
        public string Name { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public decimal? English { get; set; }
        public decimal? Urdu { get; set; }
        public decimal? Arabic { get; set; }
        public decimal? Maths { get; set; }
        public decimal? Science { get; set; }
        public decimal? Sst { get; set; }
        public decimal? Islamiat { get; set; }
        public decimal? Comp { get; set; }
        public decimal? Quran { get; set; }
        public decimal? Behav { get; set; }
        public decimal? Physics { get; set; }
        public decimal? Chemistry { get; set; }
        public decimal? Biology { get; set; }
        public decimal? AgriHe { get; set; }
        public string? StuGender { get; set; }
        public long StuId { get; set; }
        public int ClassId { get; set; }
        public string? ExamName { get; set; }
    }
}
