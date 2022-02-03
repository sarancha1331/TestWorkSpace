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
                SchoolName = "School 2"
            };

            parkService.AddBus(param);

            param = new BusParam()
            {
                BusName = "SuperBus",
                SchoolName = "School 2"
            };

            parkService.AddBus(param);

            //Тут хотим получить список автобусов в заданной школе
            var param_get = new BusParam()
            {
                SchoolName = "School 2"
            };

            parkService.GetListBus(param_get);

            // Начало Авторизации
            Console.WriteLine(" - - - АВТОРИЗАЦИЯ - - - ");
            Console.WriteLine();

            bool rezultAuthorization = false;
            string login, pass;

            do 
            { 
                Console.WriteLine("введите логин");
                login = Console.ReadLine();
                Console.WriteLine("введите пароль");
                pass = Console.ReadLine();

                rezultAuthorization = Authorization.Validation(login, pass);

                Console.WriteLine();
                if (!rezultAuthorization)
                    Console.WriteLine("Вы ввели неправильные данные! ПОВТОРИТЕ ВВОД");

                Console.WriteLine();
            }
            while(!rezultAuthorization);

            Console.WriteLine("УСПЕШНАЯ АВТОРИЗАЦИЯ " );

        }

        

    }
}

