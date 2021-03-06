using School.DataAccess;
using School.Entity;
using School.Interfaces;
using School.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service
{
    public class ParkServis : IParkService
    {

        private List<MySchool> MyDBContext;

        public ParkServis()
        {
            MyDBContext = Singleton.GetInstance.Data;
        }

        public void AddBus(BusParam busParam)
        {
            var scholl = MyDBContext.FirstOrDefault(q => q.SchoolName == busParam.SchoolName);

            var busEntity = new Bus()
            {
                Id = scholl.Park.Buses.Select(r => r.Id).LastOrDefault() + 1, 
                NameBus = busParam.BusName,
                AutoParkId = scholl.Park.Id
            };

            scholl.Park.Buses.Add(busEntity);

            var a = 333;
        }

        public void GetListBus(BusParam busParam)
        {
            //var scholl = MyDBContext.FirstOrDefault(q => q.SchoolName == busParam.SchoolName);

            var busList = MyDBContext.FirstOrDefault(q => q.SchoolName == busParam.SchoolName).Park.Buses.ToList().Select(w => w.NameBus).ToList();

            //var bn = busList.Select(q => q.NameBus).ToList();

            var i = 0;
            /*
            Console.WriteLine("В выбранной школе : " + busParam.SchoolName + " ,количество автобусов - " + scholl.Park.Buses.Count());
            Console.WriteLine();

            foreach (var item in scholl.Park.Buses)
            {
                Console.WriteLine(scholl.Park.Buses[i].NameBus);
                i++;
            }
            */
        }
    }
}
