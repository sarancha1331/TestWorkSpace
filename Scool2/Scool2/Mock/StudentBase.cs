using School.Entity;
using School.Enums;
using System.Linq;

namespace School.Mock
{
    /// <summary>
    /// 
    /// </summary>
    public class StudentBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Student> MockStudent()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student() { Id = 1, Name = "Иванов__", MyClassId = 1, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Swim, HobbyListEnum.Sport }, MediumBall = 3 });
            students.Add(new Student() { Id = 2, Name = "Петров__", MyClassId = 1, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Art }, MediumBall = 5 });
            students.Add(new Student() { Id = 3, Name = "Йцукен__", MyClassId = 2, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Sport }, MediumBall = 5 });
            students.Add(new Student() { Id = 4, Name = "Кулибаба", MyClassId = 2, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Drow }, MediumBall = 5 });
            students.Add(new Student() { Id = 5, Name = "Козладой", MyClassId = 2, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Drow }, MediumBall = 2 });
            students.Add(new Student() { Id = 6, Name = "Морозкин", MyClassId = 3, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Art }, MediumBall = 7 });
            students.Add(new Student() { Id = 7, Name = "Пупкин__", MyClassId = 4, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Swim }, MediumBall = 1 });

            return students;
        }
    }
}
