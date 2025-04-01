using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class ViewStudentsCampaignEffect
    {
        public int? AdvertisementTypeId { get; set; }
        public string AdvTypeDesc { get; set; } = null!;
        public string StuName { get; set; } = null!;
        public string StuFatherName { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public string? StAddress { get; set; }
        public string TownName { get; set; } = null!;
    }
}
