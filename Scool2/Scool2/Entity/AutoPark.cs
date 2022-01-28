using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entity
{
    public class AutoPark
    {
        public int Id { get; set; }

        public List<Bus> Buses { get; set; }

        public int MySchoolId { get; set; }

    }
}
