using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewTotalAdmission
    {
        public DateTime? AdmissionDate { get; set; }
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string Class { get; set; } = null!;
        public string Wing { get; set; } = null!;
    }
}
