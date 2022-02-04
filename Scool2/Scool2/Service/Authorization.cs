using School.Interfaces;
using School.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private bool isLoggedIn = false;

        public Authorization()
        {
            string login, pass;
            do
            {
                Console.Write("введите логин: ");
                login = Console.ReadLine();
                Console.Write("введите пароль: ");
                pass = Console.ReadLine();

                Console.WriteLine();

                if (login == Login && pass == Pass)
                {
                    isLoggedIn = true;
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
            if (!isLoggedIn)
            {
                Console.WriteLine("Access denite");
                return;
            }
            _parkService.AddBus(busParam);
        }

        public void GetListBus(BusParam busParam)
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Access denite");
                return;
            }
            _parkService.GetListBus(busParam);
        }

        public void Query1()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query1();
        }

        public void Query2()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query2();
        }

        public void Query3()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query3();
        }

        public void Query4()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query4();
        }

        public void Query5()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query5();
        }

        public void Query6()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query6();
        }

        public void Query7()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Access denite");
                return;
            }
            _mainService.Query7();
        }
    }
}
