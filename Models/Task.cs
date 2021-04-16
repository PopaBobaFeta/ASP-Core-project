using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        public String TaskName { get; set; }

        public String TaskDescription { get; set; }

        public bool done { get; set; }

        public ICollection<Event> events { get; set; }
    }
}
