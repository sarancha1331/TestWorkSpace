using School.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Mock
{
    public class ParkBase
    {
        public static List<AutoPark> MockPark()
        {
            List<AutoPark> Park = new List<AutoPark>();
            Park.Add(new AutoPark() { Id = 1 });
            Park.Add(new AutoPark() { Id = 2 });
            Park.Add(new AutoPark() { Id = 3 });
            Park.Add(new AutoPark() { Id = 4 });
            Park.Add(new AutoPark() { Id = 5 });
            Park.Add(new AutoPark() { Id = 6 });

            return Park;
        }
    }
}
