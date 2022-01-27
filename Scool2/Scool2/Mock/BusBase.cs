using School.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Mock
{
    public class BusBase
    {
        public static List<Bus> MoskBus()
        {
            List<Bus> NameBus = new List<Bus>();
            NameBus.Add(new Bus() { Id = 1, NameBus = "Богдан" });
            NameBus.Add(new Bus() { Id = 2, NameBus = "Mersedes Bus" });
            NameBus.Add(new Bus() { Id = 2, NameBus = "Икарус" });
            NameBus.Add(new Bus() { Id = 2, NameBus = "Ford Bus" });

            return NameBus;
        }
    }
}
