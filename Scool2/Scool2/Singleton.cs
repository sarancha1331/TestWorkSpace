using School.Entity;
using School.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public static class Singleton
    {

        public static List<MySchool> MyDBContext;
        
        public static object Instance()
        {
            if (MyDBContext == null)
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
                

            return MyDBContext;
        }
    }
}
