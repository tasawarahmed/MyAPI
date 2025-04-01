using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblAccAssociation
    {
        public int AccountAssociationId { get; set; }
        public string AccountAssociationName { get; set; } = null!;
        public string? Remarks { get; set; }
    }
}
