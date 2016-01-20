
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using ZLinq.Extension;

//using ZLinq.Guards;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
        /// <summary>
        /// Filter source collection using specified predicate
        /// </summary>
        /// <typeparam name="T">Type of collection</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="predicate">Function that maps elements from source collection to resulting collection</param>
        /// <returns>Array of mapped elements</returns>  	    
        [Pure]
        public static T[] WhereToArray<T>(this ICollection<T> source, Predicate<T> predicate)
        {
            Guard.Requires<ArgumentNullException>(source != null);
            Guard.Requires<ArgumentNullException>(predicate != null);
            var result = new T[source.Count];
            int i = 0;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    result[i++] = value;
                }
            }
            Array.Resize(ref result, i);
            return result;
        }


        /// <summary>
        /// Filter source collection using specified predicate
        /// </summary>
        /// <typeparam name="T">Type of collection</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="predicate">Function that maps elements from source collection to resulting collection</param>
        /// <returns>Array of mapped elements</returns>  	    
        [Pure]
        public static T[] WhereToArray<T>(this T[] source, Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            var result = new T[source.Length];
            int i = 0;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    result[i++] = value;
                }
            }
            Array.Resize(ref result, i);
            return result;
        }

        /// <summary>
        /// Filter source collection using specified predicate
        /// </summary>
        /// <typeparam name="T">Type of source collection</typeparam>
        /// <typeparam name="TResult">Type of result array</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="predicate">Function that maps elements from source collection to resulting collection</param>
        /// <returns>Array of mapped elements</returns>  	    
        [Pure]
        public static TResult[] WhereToArray<T, TResult>(this ICollection<T> source, Predicate<T> predicate, Func<T, TResult> selector)
        {
            var result = source.WhereToArray(predicate);
            return result.SelectToArray(selector);
        }


        /// <summary>
        /// Filter source collection using specified predicate
        /// </summary>
        /// <typeparam name="T">Type of source collection</typeparam>
        /// <typeparam name="TResult">Type of result array</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="predicate">Function that maps elements from source collection to resulting collection</param>
        /// <returns>Array of mapped elements</returns>  	    
        [Pure]
        public static TResult[] WhereToArray<T, TResult>(this T[] source, Predicate<T> predicate, Func<T, TResult> selector)
        {
            var result = source.WhereToArray(predicate);
            return result.SelectToArray(selector);
        }
    }
}
