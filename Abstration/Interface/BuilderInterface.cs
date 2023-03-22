using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public interface IBuilder<TBuilder, TResult>
    where TBuilder:  IBuilder<TBuilder, TResult>
    {
        abstract static TBuilder Builder();
        TResult Build();
    }
}
