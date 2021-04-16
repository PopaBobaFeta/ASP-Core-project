using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Models
{
    public class User
    {
        public int UserId { get; set; }

        public String Name { get; set; }

        public String Password { get; set; }

        public ICollection<Event> events { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
