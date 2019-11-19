using System;
using System.Collections.Generic;

namespace Day_27___SessionsRecap.Models
{
    public partial class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Director { get; set; }
        public string LeadActor { get; set; }
    }
}
