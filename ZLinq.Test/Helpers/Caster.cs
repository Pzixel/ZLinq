
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;


namespace ZLinq.Test.Helpers
{
    public static class Caster
    {        
		[Pure]
        public static IList<T> ToIList<T>(this IEnumerable<T> source)
        {
            return Enumerable.ToList(source);
        }
		[Pure]
        public static ICollection<T> ToICollection<T>(this IEnumerable<T> source)
        {
            return Enumerable.ToList(source);
        }
		[Pure]
        public static IEnumerable<T> ToIEnumerable<T>(this IEnumerable<T> source)
        {
            return Enumerable.ToList(source);
        }
		
    }
}
