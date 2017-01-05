using System.Collections.Generic;

namespace ZLinq.Core
{
    public static class QueryFactory
    {
        public static IQuery<T[], T[]> Create<T>() 
        {
            return new IdentityQuery<T[]>();
        }
    }
}
