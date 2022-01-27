using School.Entity;
using School.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Mock
{
    public class EventBase
    {
        public static List<Event> MockEvents()
        {
            List<Event> EventsName= new List<Event>();
            EventsName.Add(new Event() { Id = 1, SchoolId = 1, EventDate = new DateTime(2021, 12, 31), EventName = new List<EventListEnum>() { EventListEnum.NewYear } });
            EventsName.Add(new Event() { Id = 2, SchoolId = 2, EventDate = new DateTime(2021, 09, 01), EventName = new List<EventListEnum>() { EventListEnum.September1 } });


            return EventsName;
        }
    }
}
