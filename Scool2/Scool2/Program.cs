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

            dataConnection.AddBus(
                new BusParam()
                {
                    BusName = "Маршрутка 100",
                    SchoolName = "School 2"
                });

            dataConnection.AddBus(
                new BusParam()
                {
                    BusName = "Маршрутка 78",
                    SchoolName = "School 2"
                });

            dataConnection.GetListBus(
                new BusParam()
                {
                    SchoolName = "School 2"
                });
        }

        

    }
}

