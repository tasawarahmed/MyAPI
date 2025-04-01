using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblAccount
    {
        public int AccountId { get; set; }
        public int AccountTypeId { get; set; }
        public int? AccountAssociationId { get; set; }
        public string AccountName { get; set; } = null!;
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
    }
}
