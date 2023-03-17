using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_Charactor_Creator.Src.Models;
using DnD_Charactor_Creator.Src.Interface;

namespace DnD_Charactor_Creator.Src.Singleton
{
    public class ProjectConfigSingleton : ISingleton<ProjectConfig>
    {
        private static bool _Instance = false;
        private static ProjectConfig _Config = null!;

        private ProjectConfigSingleton()
        {
            _Config = new ProjectConfig("", "", "", "");
            _Instance = true;
        }

        public static ProjectConfig Instance()
        {
            if (!_Instance)
            {
                new ProjectConfigSingleton();
            }
            return _Config;
        }
    }
}
