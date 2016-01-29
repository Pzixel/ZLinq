
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {        
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty<T>(this T[] source)
        {
            return source == null || source.Length == 0;
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty<T>(this List<T> source)
        {
            return source == null || source.Count == 0;
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty<T>(this IList<T> source)
        {
            return source == null || source.Count == 0;
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty<T>(this ICollection<T> source)
        {
            return source == null || source.Count == 0;
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty(this IList source)
        {
            return source == null || source.Count == 0;
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty(this ICollection source)
        {
            return source == null || source.Count == 0;
        }

		[Pure]
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            if (source == null)
			{
			   return true;
			}
			using (var enumerator = source.GetEnumerator())
			{
			    if (enumerator.MoveNext())
				    return false;
			}
			return true;
        }

		[Pure]
        public static bool IsNullOrEmpty(this IEnumerable source)
        {
            if (source == null)
            {
                return true;
            }
            var enumerator = source.GetEnumerator();
            return !enumerator.MoveNext();
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }
    }
}
