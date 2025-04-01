using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewActiveStudentsContact
    {
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string Class { get; set; } = null!;
        public string Wing { get; set; } = null!;
        public string? Mobile { get; set; }
        public string? Home { get; set; }
        public string? Landline { get; set; }
        public string? Email { get; set; }
        public long StuId { get; set; }
        public string? StuRegNumber { get; set; }
        public DateTime? StuDob { get; set; }
        public string? StuFatherCnic { get; set; }
        public string? StuHomeStreet { get; set; }
        public DateTime? StuAdmDate { get; set; }
        public string AdmissionClass { get; set; } = null!;
    }
}
