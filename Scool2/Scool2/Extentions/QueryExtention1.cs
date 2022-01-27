using School.Entity;
using School.Models;

namespace School.Extentions
{
    /// <summary>
    /// 
    /// </summary>
    public static class QueryExtention1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="myClass"></param>
        /// <returns></returns>
        public static MyClassWithStudentsAndTeachers ToMyClassWithStudentsAndTeachers(this MyClass myClass)
        {
            return new MyClassWithStudentsAndTeachers() 
            {
                ClassName = myClass.ClassName,
                NameStudents = myClass.MyListStudent.Select(w => w.Name).ToList(), 
                NameTeacher = myClass.MyTeacher.Name
            };
        }
    }
}
