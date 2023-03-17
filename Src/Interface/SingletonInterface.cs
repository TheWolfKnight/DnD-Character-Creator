using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Charactor_Creator.Src.Interface
{
    public interface ISingleton<T>
    {
        static abstract T Instance();
    }
}
