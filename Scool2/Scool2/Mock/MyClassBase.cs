using School.Entity;

namespace School.Mock
{
    /// <summary>
    /// 
    /// </summary>
    public class MyClassBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<MyClass> MockUchebnogoClassa()
        {
            List<MyClass> myClass = new List<MyClass>();

            myClass.Add(new MyClass() { Id = 1, ClassName = "Класс1", SchoolId = 1, ClassId = 1});
            myClass.Add(new MyClass() { Id = 2, ClassName = "Класс2", SchoolId = 1, ClassId = 2});
            myClass.Add(new MyClass() { Id = 3, ClassName = "Класс3", SchoolId = 2, ClassId = 3});
            myClass.Add(new MyClass() { Id = 4, ClassName = "Класс4", SchoolId = 2, ClassId = 4});

            return myClass;
        }
    }
}
