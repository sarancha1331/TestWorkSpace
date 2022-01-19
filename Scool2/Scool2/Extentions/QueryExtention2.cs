using School.Entity;
using School.Models;

namespace School.Extentions
{
    /// <summary>
    /// 
    /// </summary>
    public static class QueryExtention2
    {
        /// <summary>
        /// Мапер2
        /// </summary>
        /// <param name="myClass"></param>
        /// <returns></returns>
        public static MyClassStudents ToMyStudents(this Student myStudent)
        {
            return new MyClassStudents()
            {
                NameStudent = myStudent.Name,
                ClassId = myStudent.MyClassId
            };
        }
    }
}
