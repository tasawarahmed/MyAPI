using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblStuInquiry
    {
        public int StuInqId { get; set; }
        public DateTime DateOfInquiry { get; set; }
        public string StuName { get; set; } = null!;
        public string StuFatherName { get; set; } = null!;
        public int? ClassInquired { get; set; }
        public string? StAddress { get; set; }
        public int? Town { get; set; }
        public int? AdvertisementTypeId { get; set; }
        public bool? TakenProspectus { get; set; }
        public bool? SubmittedAdmForm { get; set; }
        public bool? AppearedInAdmTest { get; set; }
        public bool? TakenAdmission { get; set; }
        public string? RemarksStuInquiry { get; set; }
        public string? ContactNumber { get; set; }
        public bool? FinalizeInquiry { get; set; }
    }
}
