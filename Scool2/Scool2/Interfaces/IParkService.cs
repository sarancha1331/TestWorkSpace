using School.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Interfaces
{
    public interface IParkService
    {
        public void AddBus(BusParam busParam);

        public void GetListBus(BusParam busParam);
    }
}
