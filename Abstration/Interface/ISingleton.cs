using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public interface ISingleton<T>
    {
        static abstract ref T Instance();
    }
}
