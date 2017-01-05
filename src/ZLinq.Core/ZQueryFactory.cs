using System.Collections.Generic;

namespace ZLinq.Core
{
    public static class ZQueryFactory
    {
        public static ZQuery<T> AsZQuery<T>(this IEnumerable<T> enumerable)
        {
            return new ZQuery<T>(enumerable);
        }
    }
}
