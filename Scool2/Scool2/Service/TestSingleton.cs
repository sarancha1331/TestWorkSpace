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
    public class TestSingleton 
    {

        public TestSingleton()
        {
            var Test = Singleton.GetInstance.Data;

            Test.Add(new MySchool());

            var a = 1;

        }
    }
}
