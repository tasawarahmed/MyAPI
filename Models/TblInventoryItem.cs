using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblInventoryItem
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public byte[]? Image { get; set; }
        public string? ImageType { get; set; }
        public string? ImageSize { get; set; }
        public string? ImageUrl { get; set; }
    }
}
