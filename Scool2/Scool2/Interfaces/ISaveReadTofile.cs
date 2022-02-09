using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Interfaces
{
    public interface ISaveReadToFile
    {
        public void SaveToFile();

        public void ReadFromFile();

        public void VerifyData();
    }
}
