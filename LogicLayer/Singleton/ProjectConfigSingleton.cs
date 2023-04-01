using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Abstraction.Models;
using Abstraction.Interface;

using LogicLayer.Service;

namespace LogicLayer.Singleton
{
    public class ProjectConfigSingleton : ISingleton<ProjectConfigSingleton>
    {
        private static ProjectConfigSingleton _Instance { get; set; } = new ProjectConfigSingleton();
        private ProjectConfig _Config = null!;

        private ProjectConfigSingleton()
        {
            _Config = LoadConfigService.Load("");
        }

        public static ProjectConfigSingleton Instance()
        {
            return _Instance;
        }
    }
}
