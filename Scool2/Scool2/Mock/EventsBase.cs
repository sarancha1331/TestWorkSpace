using School.Entity;
using School.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Mock
{
    public class EventsBase
    {
        public static List<Events> MockEvents()
        {
            List<Events> EventsName= new List<Events>();
            EventsName.Add(new Events() { Id = 1, SchoolId = 1, EventsDate = new DateTime(2021, 12, 31), EventName = new List<EventsListEnum>() { EventsListEnum.NewYear } });
            EventsName.Add(new Events() { Id = 2, SchoolId = 2, EventsDate = new DateTime(2021, 09, 01), EventName = new List<EventsListEnum>() { EventsListEnum.September1 } });


            return EventsName;
        }
    }
}
