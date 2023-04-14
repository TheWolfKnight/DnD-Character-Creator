using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Enumerators
{
    public enum Genders
    {
        /// <summary>
        /// Is a Man
        /// </summary>
        Male     = 0,
        /// <summary>
        /// Is a Woman
        /// </summary>
        Female   = 1,
        /// <summary>
        /// Could be either at any time, but is currently one
        /// or the other.
        /// </summary>
        Ambigues = 2,
    }
}
