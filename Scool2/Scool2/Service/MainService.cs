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
        private List<int> classArray = new List<int> { 2, 4, 6 };

        /// <summary>
        /// Массив школ
        /// </summary>
        private List<int> schoolArray = new List<int> { 1, 2 };

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
        /// Список всех студентов их класс и учитель. Смапить в модель1
        /// </summary>
        public void Query1()
        {
            //var test = HobbyListEnum.Swim.GetEnumDescription();

            
            var rezult1 = MyDBContext.Where(z => z.Id == 1).ToList();    

            var a1 = 999;

            var rezult1_1 = MyDBContext.Where(a => a.Id == 1)
                .SelectMany(q => q.MyClasses
                    .Select(r => r.ToMyClassWithStudentsAndTeachers()))
                .ToList();

            var a2 = 1; 
        }

        /// <summary> ЗАДАНИЕ 2:
        /// Список всех студентов из 2, 4 и 6 классов
        /// 
        ///        Name = "Йцукен__", MyClassId = 2, Hobby
        ///        Name = "Кулибаба", MyClassId = 2, Hobby
        ///        Name = "Козладой", MyClassId = 2, Hobby

        ///        Name = "Пупкин__", MyClassId = 4, Hobby
        /// </summary>
        public void Query2()
        {
            /*
            var r2 = MyDBContext.Where(z => z.Id == 1 || z.Id == 2)
                .SelectMany(x => x.MyClasses
                    .Where(v => v.Id ==2 || v.Id == 4 || v.Id == 6)
                        .Select(c => c.ToMyStudents()))
                .ToList();


            var query = MyDBContext.Where(r => r.Id == 1 || r.Id == 2)
                .SelectMany(t => t.MyClasses);

            var result2 = MyDBContext.SelectMany(y => query
                .Where(h => classArray.Contains(h.Id) && h.SchoolId == y.Id).SelectMany(e => e.MyListStudents))
                .ToList();
            */

            var result2_1 = MyDBContext.SelectMany(y => y.MyClasses
                .Where(h => classArray.Contains(h.Id) &&
                            schoolArray.Contains(h.SchoolId))
                .SelectMany(e => e.MyListStudents
                    .Select(q => q.ToMyStudents())))
                .ToList();

            var a1 = 3;
        }

        /// <summary> Задание 3.
        /// Есть ли хоть 1 студент из 2 класса школы №1
        /// Студенты есть в 1,2,3,4 классе
        /// Класс 1,2 в школе 1, Классы 3,4 в школе 2
        /// </summary>
        public void Query3()
        {
            var rezult3 = MyDBContext.SelectMany(b => b.MyClasses.Where(q => q.Id == 2))
                .Any(e => e.SchoolId == 1);

            var a2 = 2;
            //var r2 = MyDBContext.SelectMany(b => b.MyClasses.Where(q => q.Id == 2));
            //var s = MyDBContext.Select(q => q.MyClasses.Where(w => w.Id == 2).ToList().Any(i => i.SchoolId == 1));
            //var rezult3 = MyDBContext.Select(q => q.MyClasses.Where(w => w.Id == 2).FirstOrDefault()).Any(o => o.SchoolId == 1);

            var a1 = 1;

        }

        /// <summary>
        /// Добавить студентам уникальное поле.Хобби.Сделать выборку по массиву студентов
        /// которые занимаются (Плаванием, рисованием и стрельбой) Спортом 

        /// 1 класс - Иванов
        /// 2 класс - Йцукен
        /// </summary>
        public void Query4()
        {
            /*
            var rezu4 = MyDBContext.SelectMany(q => q.MyListStudents
                .Where(w => w.Hobby
                    .Any(e => e == HobbyListEnum.Sport)))
                .ToList();
            */
            var rezult4 = MyDBContext.SelectMany(q => q.MyClasses)
                .SelectMany(w => w.MyListStudents
                .Where(e => e.Hobby
                .Any(r => r == HobbyListEnum.Sport)))
                .ToList();

            var b = 333;
            
        }

        /// <summary>
        /// 5. Выборка по всем классам. вывести средний бал всех оценок в классе
        /// Во втором классе (баллы 5, 5, 2)   - средний балл 4
        /// 
        /// </summary>
        public void Query5()
        {
            
            //var rezult5_0 = MyDBContext.SelectMany(q => q.MyListStudents.Where(w => w.MyClassId == 2)).Average(n => n.MediumBall);

            // Выводим средний балл по второму классу
            var rezult5 = MyDBContext.SelectMany(q => q.MyClasses)
                .SelectMany(w => w.MyListStudents
                .Where(e => e.MyClassId == 2))
                .Average(r => r.MediumBall);
            
            var b = 1;
        }
        /// <summary>
        /// 6. Добавляешь ещё список классов(другая школа). Выводишь на экран через Linq учеников всех классов двух школ
        /// </summary>
        public void Query6()
        {
            //var rezult6 = MyDBContext.Select(q => q.Id == 1 || q.Id == 2).ToList();

            var result6 = MyDBContext.SelectMany(y => y.MyClasses
                         .Where(h => schoolArray.Contains(h.SchoolId))
                         .SelectMany(e => e.MyListStudents
                             .Select(q => q.ToMyStudents())))
                         .ToList();

            foreach (var item in result6)
            {
                Console.WriteLine(item.NameStudent);
            }    
            
            var bb = 1;

        }


        //7. Выводишь ученика с самым маленьким средним баллом по 2 школам и с самым большим средним баллом

    }
}
