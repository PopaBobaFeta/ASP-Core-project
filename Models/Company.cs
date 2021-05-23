  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Event> events { get; set; }
    }
}
