using System;

namespace ZLinq.Core
{
    public class IdentityQuery<T> : IQuery<T, T>
    {
        public Func<T, T> Compile()
        {
            return x => x;
        }
    }
}