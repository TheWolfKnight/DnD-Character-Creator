using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using Abstraction.Models;
using Abstraction.Interface;
using System.ServiceProcess;

namespace Builder
{
    public class ConfigBuilder: IBuilder<ConfigBuilder, ProjectConfig>
    {
        private ProjectConfig _Result = null!;

        private ConfigBuilder()
        {
            _Result = new ProjectConfig(string.Empty, string.Empty, string.Empty, string.Empty);
        }

        public static ConfigBuilder Builder()
        {
            return new ConfigBuilder();
        }

        public ConfigBuilder SetRootDir(string rootDirPath)
        {
            _Result.RootDir = rootDirPath;
            return this;
        }

        public ConfigBuilder SetCharacterDir(string charDirPath)
        {
            _Result.CharDir = charDirPath;
            return this;
        }

        public ConfigBuilder SetItemDir(string itemDirPath)
        {
            _Result.ItemDir = itemDirPath;
            return this;
        }

        public ConfigBuilder SetSpellDir(string spellDirPath)
        {
            _Result.SpellDir = spellDirPath;
            return this;
        }

        public ProjectConfig Build()
        {
            return _Result;
        }
    }
}
 