using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Charactor_Creator.Src.Interface
{
    public interface IBuilder<TBuilder, TResult>
    where TBuilder: IBuilder<TBuilder, TResult>
    {
        abstract static TBuilder Builder();
        TResult Build();
    }
}
