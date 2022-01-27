using School.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entity
{
    public class Event
    {
        public int Id { get; set; }

        public List<EventListEnum> EventName { get; set; }

        public DateTime EventDate { get; set; }

        public int SchoolId { get; set; }
    }
}
