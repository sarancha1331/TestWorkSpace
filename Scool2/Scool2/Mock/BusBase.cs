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
        public static List<Bus> MockBus()
        {
            List<Bus> nameBus = new List<Bus>();
            nameBus.Add(new Bus() { Id = 1, NameBus = "Богдан", AutoParkId = 1 });
            nameBus.Add(new Bus() { Id = 2, NameBus = "Mersedes Bus", AutoParkId = 2 });
            nameBus.Add(new Bus() { Id = 3, NameBus = "Икарус", AutoParkId = 3 });
            nameBus.Add(new Bus() { Id = 4, NameBus = "Ford Bus", AutoParkId = 4 });

            return nameBus;
        }
    }
}
