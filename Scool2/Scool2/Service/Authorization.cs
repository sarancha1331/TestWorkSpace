using School.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service
{
    public class Authorization //: IAuthorization
    {
        private static string Login = "Admin";

        private static string Pass = "Admin";
 
        public static bool Validation(string login, string pass)
        {
            if (login == Login & pass == Pass)
                return true;
            else
                return false;
        }
    }
}
