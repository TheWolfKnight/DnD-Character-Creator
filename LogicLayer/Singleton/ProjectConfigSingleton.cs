using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Abstraction.Models;
using Abstraction.Interface;
using Abstraction.Enumerators;

namespace LogicLayer.Singleton
{
    public class ProjectConfigSingleton : ISingleton<ProjectConfig>
    {
        private static ProjectConfigSingleton _Instance { get; set; } = new ProjectConfigSingleton();
        private ProjectConfig _Config = null!;

        private ProjectConfigSingleton()
        {
            _Config = new ProjectConfig(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        public static ref ProjectConfig Instance()
        {
            return ref _Instance._Config;
        }
    }
}
