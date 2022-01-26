using School.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entity
{
    public class Events
    {
        public int Id { get; set; }

        public List<EventsListEnum> EventName { get; set; }

        public DateTime EventsDate { get; set; }

        public int SchoolId { get; set; }
    }
}
