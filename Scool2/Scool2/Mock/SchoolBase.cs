using School.Entity;

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

            mySchool.Add(new MySchool() {   Id = 1, SchoolName = "School 1", Characteristics = new List<Enums.AvailabilityOfAdditionalSections>() { Enums.AvailabilityOfAdditionalSections.ComputerClass}});
            
            mySchool.Add(new MySchool() { Id = 2, SchoolName = "School 2", Characteristics = new List<Enums.AvailabilityOfAdditionalSections>() { Enums.AvailabilityOfAdditionalSections.Gym }});

            return mySchool;
        }
    }
}
