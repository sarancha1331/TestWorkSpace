using School.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace School.Service
{
    public class SettingService
    {
        private SettingProject _setting { get; set; }

        public SettingService()
        {
            
            using (FileStream fs = new FileStream("C:\\TASKS\\GitHubMain\\Scool2\\Scool2\\Config.json", FileMode.OpenOrCreate))
            {
                _setting = JsonSerializer.Deserialize<SettingProject>(fs);
            }
            

            var aaa = 2;
        }

        public SettingProject GetSetting()
        {
            return _setting;
        }
    }
}
