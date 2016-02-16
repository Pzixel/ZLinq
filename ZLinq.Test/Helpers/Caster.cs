
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using ZLinq.Test.Helpers.Wrappers;


namespace ZLinq.Test.Helpers
{
    public static class Caster
    {        
        [Pure]
        public static IList<T> ToIList<T>(this IEnumerable<T> source)
        {
            return new WrapperIList<T>(source);
        }
        [Pure]
        public static ICollection<T> ToICollection<T>(this IEnumerable<T> source)
        {
            return new WrapperICollection<T>(source);
        }
        [Pure]
        public static IEnumerable<T> ToIEnumerable<T>(this IEnumerable<T> source)
        {
            return new WrapperIEnumerable<T>(source);
        }
        [Pure]
        public static IList ToIListNonGen<T>(this IEnumerable<T> source)
        {
            return new WrapperIListNonGen<T>(source);
        }
        [Pure]
        public static ICollection ToICollectionNonGen<T>(this IEnumerable<T> source)
        {
            return new WrapperICollectionNonGen<T>(source);
        }
        [Pure]
        public static IEnumerable ToIEnumerableNonGen<T>(this IEnumerable<T> source)
        {
            return new WrapperIEnumerableNonGen<T>(source);
        }
        
    }
}
