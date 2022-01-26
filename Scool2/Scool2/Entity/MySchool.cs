using School.Enums;

namespace School.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class MySchool
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SchoolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<MyClass> MyClasses { get; set; }

        /// <summary>
        /// Характеристика Школы
        /// </summary>
        public List<AvailabilityOfAdditionalSectionsEnums> Characteristics { get; set; }

        //public int EventsId { get; set; }

        public List<Events> Events { get; set; }
    }
}
