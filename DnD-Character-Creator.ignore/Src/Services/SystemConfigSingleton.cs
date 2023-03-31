using Abstraction.Interface;
using Abstration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Charactor_Creator.Src.Services
{
    public class SystemConfigSingleton : ISingleton<SystemConfigSingleton>
    {
        private static SystemConfigSingleton _Instance = new SystemConfigSingleton();
        private SystemConfig Config = null!;

        private SystemConfigSingleton() {
            Config = new SystemConfig();
        }

        public static SystemConfigSingleton Instance()
        {
            return _Instance;
        }
    }
}
