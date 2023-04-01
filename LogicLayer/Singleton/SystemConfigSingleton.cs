using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.Interface;
using Abstraction.Models;

namespace LogicLayer.Singleton
{
    public class SystemConfigSingleton : ISingleton<SystemConfig>
    {
        private static SystemConfigSingleton _Instance { get; set; } = new SystemConfigSingleton();
        private SystemConfig _Config = null!;

        private SystemConfigSingleton()
        {
            _Config = new SystemConfig();
        }

        public static ref SystemConfig Instance()
        {
            return ref _Instance._Config;
        }
    }
}
