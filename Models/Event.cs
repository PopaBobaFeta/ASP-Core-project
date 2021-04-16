using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public String EventName { get; set; }
        
        public String EventDescription { get; set; }

        public String EventType { get; set; }

        public DateTime ReleaseDate { get; set; }

        
        public User author { get; set; }

        public Company company { get; set; }
    }
}
