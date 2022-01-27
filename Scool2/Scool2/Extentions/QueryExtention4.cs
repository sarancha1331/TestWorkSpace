using School.Entity;
using School.Models;

namespace School.Extentions
{
    /// <summary>
    /// 
    /// </summary>
    public static class QueryExtention4
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="myClass"></param>
        /// <returns></returns>
        public static StudentsHobby ToStudentsHobby(this MyClass myClass)
        {
            return new StudentsHobby()
            {
                NameStudents = myClass.MyListStudent.Select(w => w.Name).ToList(),
            };
        }
    }
}
