using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblMngtMeeting
    {
        public int Id { get; set; }
        public string? Date { get; set; }
        public string? Participants { get; set; }
        public string? Venue { get; set; }
        public string? Agenda { get; set; }
        public string? Minutes { get; set; }
        public string? Actions { get; set; }
    }
}
