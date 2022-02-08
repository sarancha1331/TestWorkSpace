using School.Interfaces;
using School.Js;
using School.Mock;
using School.Param;
using School.Service;
using School.WorkingWithFiles;
using System.Text.Json;

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

            DirAndFiles dirAndFiles = new DirAndFiles();
            dirAndFiles.Dir("d:/1", "222");

            //DirAndFiles.Dir("d:/1", "222");
            dirAndFiles.CreateTxtFile1("d:/1", "222", "111_new.txt");



            DirAndFiles.CreateTxtFile("d:/1", "222","111.txt");

            DirAndFiles.CreateDocFile("d:/1", "222", "111.doc");

            DirAndFiles.CreateExlFile("d:/1", "222", "111.xls");
        }

        

    }
}

