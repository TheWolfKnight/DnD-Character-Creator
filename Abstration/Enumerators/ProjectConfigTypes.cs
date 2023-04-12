using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Enumerators
{
    /// <summary>
    /// Defines the filetype that a project file is saved in.
    /// </summary>
    public enum ProjectConfigTypes
    {
        /// <summary>
        /// File type toml
        /// </summary>
        FILETYPE_TOML = 0,

        /// <summary>
        /// File type JSON
        /// </summary>
        FILETYPE_JSON = 1,

        /// <summary>
        /// File type XML
        /// </summary>
        FILETYPE_XML  = 2,
    }
}
