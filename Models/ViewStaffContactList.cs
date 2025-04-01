using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewStaffContactList
    {
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string PrimarySubject { get; set; } = null!;
        public string? Mobile { get; set; }
        public string? Ptcl { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string Town { get; set; } = null!;
    }
}
