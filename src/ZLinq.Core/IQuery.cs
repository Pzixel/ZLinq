using System;
using System.Collections.Generic;

namespace ZLinq.Core
{
    public interface IQuery<in TSource, out TResult> 
    {
        Func<TSource, TResult> Compile();
    }
}
