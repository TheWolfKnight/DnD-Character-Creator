using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.Interface;
using Abstraction.Models;

namespace LogicLayer.Singleton
{
    public class SystemConfigSingleton : ISingleton<SystemConfigSingleton>
    {
        private static SystemConfigSingleton _Instance { get; set; } = new SystemConfigSingleton();
        private SystemConfig _Config { get; set; } = null!;

        private SystemConfigSingleton()
        {
            _Config = new SystemConfig();
        }

        public static SystemConfigSingleton Instance()
        {
            return _Instance;
        }
    }
}
