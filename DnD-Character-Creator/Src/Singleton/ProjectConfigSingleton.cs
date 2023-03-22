using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.Models;
using Abstraction.Interface;

namespace DnD_Charactor_Creator.Src.Singleton
{
    public class ProjectConfigSingleton : ISingleton<ProjectConfigSingleton>
    {
        private static ProjectConfigSingleton _Instance = null!;
        private ProjectConfig _Config = null!;

        private ProjectConfigSingleton()
        {
            _Config = new ProjectConfig("", "", "", "");
        }

        public static ProjectConfigSingleton Instance()
        {
            if (_Instance == null)
                _Instance = new ProjectConfigSingleton();
            return _Instance;
        }

        public void SetConfig(ProjectConfig config) => _Config = config;

        #region Getter Region

        public string GetRootDir() => _Config.RootDir;
        public string GetInvetoryDir() => _Config.ItemDir;
        public string GetSpellDir() => _Config.SpellDir;
        public string GetCharacterDir() => _Config.CharDir;

        #endregion
    }
}
