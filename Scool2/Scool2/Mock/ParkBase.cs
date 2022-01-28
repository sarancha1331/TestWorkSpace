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
            List<AutoPark> park = new List<AutoPark>();

            park.Add(new AutoPark() { Id = 1, MySchoolId = 1 });
            park.Add(new AutoPark() { Id = 2, MySchoolId = 2 });
            park.Add(new AutoPark() { Id = 3, MySchoolId = 3 });
            park.Add(new AutoPark() { Id = 4, MySchoolId = 4 });
            park.Add(new AutoPark() { Id = 5, MySchoolId = 5 });
            park.Add(new AutoPark() { Id = 6, MySchoolId = 6 });

            return park;
        }
    }
}
