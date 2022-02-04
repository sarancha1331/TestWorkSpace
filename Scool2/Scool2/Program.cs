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
             IAuthorization dataConnection = new Authorization();

            dataConnection.GetListBus(
                new BusParam()
                {
                    SchoolName = "School 2"
                });
        }

        

    }
}

