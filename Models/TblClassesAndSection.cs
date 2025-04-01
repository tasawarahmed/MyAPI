using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblClassesAndSection
    {
        public int ClassId { get; set; }
        public string SectionAlias { get; set; } = null!;
    }
}
