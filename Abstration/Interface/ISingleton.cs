using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public interface ISingleton<T>
    where T: ISingleton<T>
    {
        static abstract T Instance();
    }
}
