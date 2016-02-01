
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;


namespace ZLinq.Test.Helpers
{
    [SuppressMessage("ReSharper", "InvokeAsExtensionMethod")]
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
		[Pure]
        public static IList ToIListNonGen<T>(this IEnumerable<T> source)
        {
            return Enumerable.ToList(source);
        }
		[Pure]
        public static ICollection ToICollectionNonGen<T>(this IEnumerable<T> source)
        {
            return Enumerable.ToList(source);
        }
		[Pure]
        public static IEnumerable ToIEnumerableNonGen<T>(this IEnumerable<T> source)
        {
            return Enumerable.ToList(source);
        }
		
    }
}
