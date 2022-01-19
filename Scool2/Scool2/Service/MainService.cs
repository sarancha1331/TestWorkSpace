using School.Entity;
using School.Enums;
using School.Extentions;
using School.Interfaces;
using School.Mock;
using System.Linq;

namespace School.Service
{
    /// <summary>
    /// Главный сервис
    /// </summary>
    public class MainService : IMainService
    {
        /// <summary>
        /// Переменная для обращения к "БД"
        /// </summary>
        private List<MySchool> MyDBContext;

        /// <summary>
        /// Массив классов для запроса
        /// </summary>
        private int[] classArray = new[] { 2, 4, 6 };

        /// <summary>
        /// 
        /// </summary>
        public void LocalConstructor()
        {
            MyDBContext = new List<MySchool>();

            var stu = StudentBase.MockStudent();
            var teach = TeacherBase.MockTeacher();
            var kls = MyClassBase.MockUchebnogoClassa();
            var sch = SchoolBase.MockMySchool();

            foreach (var schoolItem in sch)
            {
                schoolItem.MyClasses = kls.Where(q => q.SchoolId == schoolItem.Id).ToList();

                foreach (var myClassItem in schoolItem.MyClasses)
                {
                    myClassItem.MyTeacher = teach.FirstOrDefault(q => q.MyClassId == myClassItem.Id);
                    myClassItem.MyListStudents = stu.Where(w => w.MyClassId == myClassItem.Id).ToList();
                }

                MyDBContext.Add(schoolItem);
            }
        }

        /// <summary>
        /// Список всех студентов их класс и учитель. Смапить в модель1(по поводу маминга придешь спросишь как будет время)
        /// </summary>
        public void Query1()
        {
            var test = HobbyListEnum.Swim.GetEnumDescription();

            
            var r1 = MyDBContext.Where(z => z.Id == 1).ToList();    

            var iuyi = 999;

            var r1_1 = MyDBContext.Where(a => a.Id == 1)
                .SelectMany(q => q.MyClasses
                    .Select(r => r.ToMyClassWithStudentsAndTeachers()))
                .ToList();

            var tttttttt1 = 1; 
            
            /*
            var rezult = MyDBContext.Select(a => a.ToMyClassWithStudentsAndTeachers()).ToList();
            

            var rezult1_1 = MyDBContext.Select(q => new
            {
                test1 = q.ClassName,
                test2 = q.MyListStudents.Select(w => w.Name).ToList(),
                test3 = q.MyTeacher.Name
            }).ToList();

            var a = 333;
            */
        }

        /// <summary>
        /// Список всех студентов из 2, 4 и 6 классов
        /// 
        ///        Name = "Йцукен__", MyClassId = 2, Hobby
        ///        Name = "Кулибаба", MyClassId = 2, Hobby
        ///        Name = "Козладой", MyClassId = 2, Hobby

        ///        Name = "Пупкин__", MyClassId = 4, Hobby
        /// </summary>
        public void Query2()
        {
            var r2 = MyDBContext.Where(z => z.Id == 1 || z.Id == 2)
                .SelectMany(x => x.MyClasses
                    .Where(v => v.Id ==2 || v.Id == 4 || v.Id == 6)
                        .Select(c => c.ToMyStudents()))
                .ToList();


            //var r3 = MyDBContext.Where(q => q.Id == 1).Select(w => w.MyClasses).ToList();

            var r4 = MyDBContext.Where(q => q.Id == 1).Select(w => w.MyClasses).ToList();


            var b = 333;
            /*
            var rezult2 = MyDBContext.Where(b => b.Id == 2 || b.Id == 4).Select(ww => ww.ToMyStudents()).ToList();
            var b = 333;
            */
        }

        /// <summary>
        /// Есть ли хоть 1 студент из 5 класса
        /// </summary>
        public void Query3()
        {
            /*
            var rezult3 = MyDBContext.Any(b => b.Id == 2);
            var b = 333;
            */
        }

        /// <summary>
        /// Добавить студентам уникальное поле.Хобби.Сделать выборку по массиву студентов
        /// которые занимаются Плаванием, рисованием и стрельбой
        /// </summary>
        public void Query4()
        {
            /*
            var rezu4 = MyDBContext.SelectMany(q => q.MyListStudents
                .Where(w => w.Hobby
                    .Any(e => e == HobbyListEnum.Sport)))
                .ToList();

            var b = 333;
            */
        }

        /// <summary>
        /// 
        /// </summary>
        public void Query5()
        {
            /*
            //var rezult5 = MyDBContext.SelectMany(q => q.MyListStudents.Where(w => w.MyClassId == 2)).ToList();
            var rezult5 = MyDBContext.SelectMany(q => q.MyListStudents.Where(w => w.MyClassId == 2)).Average(n => n.MediumBall);

            var b = 1;
            */
        }
        //6. Добавляешь ещё список классов(другая школа). Выводишь на экран через Linq учеников всех классов двух школ

    }
}
