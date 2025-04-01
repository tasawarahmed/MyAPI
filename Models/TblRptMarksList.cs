using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblRptMarksList
    {
        public int StuId { get; set; }
        public int ClassId { get; set; }
        public int ExamId { get; set; }
        public int? EnglishTotal { get; set; }
        public decimal? EnglishObtained { get; set; }
        public int? UrduTotal { get; set; }
        public decimal? UrduObtained { get; set; }
        public int? ArabicTotal { get; set; }
        public decimal? ArabicObtained { get; set; }
        public int? MathematicsTotal { get; set; }
        public decimal? MathematicsObtained { get; set; }
        public int? ScienceTotal { get; set; }
        public decimal? ScienceObtained { get; set; }
        public int? SocialStudiesTotal { get; set; }
        public decimal? SocialStudiesObtained { get; set; }
        public int? IslamiatTotal { get; set; }
        public decimal? IslamiatObtained { get; set; }
        public int? ComputerTotal { get; set; }
        public decimal? ComputerObtained { get; set; }
        public int? QuranTotal { get; set; }
        public decimal? QuranObtained { get; set; }
        public int? BehaviorTotal { get; set; }
        public decimal? BehaviorObtained { get; set; }
        public int? PhysicsTotal { get; set; }
        public decimal? PhysicsObtained { get; set; }
        public int? ChemistryTotal { get; set; }
        public decimal? ChemistryObtained { get; set; }
        public int? BiologyTotal { get; set; }
        public decimal? BiologyObtained { get; set; }
        public int? AgriHeconomicsTotal { get; set; }
        public decimal? AgriHeconomicsObtained { get; set; }
        public string? ExamName { get; set; }
    }
}
