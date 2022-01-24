using School.Entity;
using School.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Singleton
    {
        private static Singleton Instance;

        private Singleton()
        {

        }
        
        public static Singleton GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
                    SetData();
                }
                return Instance;
            }
         }

        public List<MySchool> Data;

        private static void SetData()
        {
            Instance.Data = new List<MySchool>();

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

                Instance.Data.Add(schoolItem);
            }

        }
    }
}
