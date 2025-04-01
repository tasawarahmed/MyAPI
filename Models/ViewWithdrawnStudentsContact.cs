using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewWithdrawnStudentsContact
    {
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string Class { get; set; } = null!;
        public string Wing { get; set; } = null!;
        public string? Mobile { get; set; }
        public string? Home { get; set; }
        public string? Landline { get; set; }
        public string? Email { get; set; }
        public DateTime? StuWithDrawalDate { get; set; }
    }
}
