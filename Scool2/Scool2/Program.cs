using School.Interfaces;
using School.Mock;
using School.Param;
using School.Service;

namespace School
{
    public class Program
    {
 
        public static void Main()
        {
            IMainService service = new MainService();
            TestSingleton testService = new TestSingleton();
            IParkService parkService = new ParkServis();

            service.LocalConstructor();

            service.Query1();

            service.Query2();

            service.Query3();

            service.Query4();

            service.Query5();

            service.Query6();

            service.Query7();

 

            var param = new BusParam() 
            {
                BusName = "Автобусик",
                SchoolName = "School 1"
            };

            parkService.AddBus(param);
        }

    }
}

