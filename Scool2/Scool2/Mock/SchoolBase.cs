using School.Entity;
using School.Enums;

namespace School.Mock
{
    /// <summary>
    /// 
    /// </summary>
    public class SchoolBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<MySchool> MockMySchool()
        {
            List<MySchool> mySchool = new List<MySchool>();

            mySchool.Add(new MySchool() { Id = 1, SchoolName = "School 1", Characteristic = new List<AvailabilityOfAdditionalSectionsEnum>() { AvailabilityOfAdditionalSectionsEnum.ComputerClass } });

            mySchool.Add(new MySchool() { Id = 2, SchoolName = "School 2", Characteristic = new List<AvailabilityOfAdditionalSectionsEnum>() { AvailabilityOfAdditionalSectionsEnum.Gym }});

            return mySchool;
        }
    }
}
