using School.DataAccess;
using School.Interfaces;
using School.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using School.Js;
using System.Text.Json;

namespace School.Service
{
    public class Authorization : IAuthorization, IMainService, IParkService
    {
        private const string Login = "Admin";
        private const string Pass = "Admin";

        /// <summary>
        /// 
        /// </summary>
        private IMainService _mainService;

        /// <summary>
        /// 
        /// </summary>
        private IParkService _parkService;

        public Authorization()
        {
            string login, pass;
            do
            {
                bool OnOff;
                using (FileStream fs = new FileStream("C:\\TASKS\\GitHubMain\\Authorization.json", FileMode.OpenOrCreate))
                {
                    Qwe authorization = JsonSerializer.Deserialize<Qwe>(fs);
                    OnOff = authorization.OnOff;
                }

                if (OnOff == true)
                {
                    Console.Write("введите логин: ");
                    login = Console.ReadLine();
                    Console.Write("введите пароль: ");
                    pass = Console.ReadLine();
                }
                else
                {
                    login = "Admin";
                    pass = "Admin";
                }

                Console.WriteLine();

                if (Singleton.CheckAccessIsSuccesful(login, pass))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильные данные! ПОВТОРИТЕ ВВОД");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (true);

            _mainService = new MainService();
            _parkService = new ParkServis();

    }

        public void AddBus(BusParam busParam)
        {
            if (!Singleton.IsAuthorization())
            {
                Console.WriteLine("Access denite");
                return;
            }
            _parkService.AddBus(busParam);
        }

        public void GetListBus(BusParam busParam)
        {
            if (!Singleton.IsAuthorization())
            {
                Console.WriteLine("Access denite");
                return;
            }
            _parkService.GetListBus(busParam);
        }

        public void Query1()
        {
            if (!Singleton.IsAuthorization())
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query1();
        }

        public void Query2()
        {
            if (!Singleton.IsAuthorization())
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query2();
        }

        public void Query3()
        {
            if (!Singleton.IsAuthorization())
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query3();
        }

        public void Query4()
        {
            if (!Singleton.IsAuthorization())
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query4();
        }

        public void Query5()
        {
            if (!Singleton.IsAuthorization())
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query5();
        }

        public void Query6()
        {
            if (!Singleton.IsAuthorization())
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query6();
        }

        public void Query7()
        {
            if (!Singleton.IsAuthorization())
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query7();
        }
    }
}
