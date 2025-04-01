using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblGenParty
    {
        public int Id { get; set; }
        public string NameAddress { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
