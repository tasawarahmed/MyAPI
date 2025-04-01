using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblQuestionsCategory
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public int? OrderOfAppearance { get; set; }
    }
}
