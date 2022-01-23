using School.Interfaces;
using School.Service;

namespace School
{
    public class Program
    {
 
        public static void Main()
        {
            IMainService service = new MainService();

            service.LocalConstructor();

            service.Query1();

            service.Query2();

            service.Query3();

            service.Query4();

            service.Query5();

            service.Query6();
            //оловал
            //Моё изменение1
        }

    }
}

