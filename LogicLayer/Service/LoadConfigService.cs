using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.Models;
using Abstraction.Enumerators;

namespace LogicLayer.Service
{
    /// <summary>
    /// 
    /// </summary>
    public static class LoadConfigService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileType"></param>
        /// <returns></returns>
        public static ProjectConfig Load(string path, ProjectConfigTypes fileType=ProjectConfigTypes.FILETYPE_JSON)
        {
            throw new NotImplementedException();
        }

        private static ProjectConfig load_JSON(string path)
        {
            throw new NotImplementedException();
        }

        private static ProjectConfig load_TOML(string path)
        {
            throw new NotImplementedException();
        }

        private static ProjectConfig load_XML(string path)
        {
            throw new NotImplementedException();
        }
    }
}
