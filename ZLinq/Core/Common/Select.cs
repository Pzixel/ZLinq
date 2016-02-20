
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using JetBrains.Annotations;
using ZLinq.Common;
using ZLinq.CommonInternal;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    [SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
    public static partial class ZEnumerable
    {    
                
        
        /// <summary>
        /// Map each element of source collection to an element of resulting array
        /// </summary>
        /// <typeparam name="T">Type of source collection</typeparam>
        /// <typeparam name="TResult">Type of result array</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="func">Function that maps elements from source collection to resulting collection</param>
        /// <returns>Array of mapped elements</returns>  
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        [NotNull]
        public static TResult[] SelectToArray<T, TResult>([NotNull] this T[] source, [NotNull] Func<T, TResult> func)
        {
            source.IsNotNull(nameof(source));
            func.IsNotNull(nameof(func));
            var result = new TResult[source.Length];
            int i;
            for (i = 0; i < result.Length - Constants.Step + 1; i += Constants.Step)
            {
                TResult res1 = func(source[i]);
                TResult res2 = func(source[i + 1]);
                TResult res3 = func(source[i + 2]);
                TResult res4 = func(source[i + 3]);

                result[i] = res1;
                result[i + 1] = res2;
                result[i + 2] = res3;
                result[i + 3] = res4;
            }
            
            if (i <= result.Length - 1)
            {
                if (i <= result.Length - 2)
                {
                    if (i <= result.Length - 3)
                    {
                        result[result.Length - 3] = func(source[result.Length - 3]);
                    }
                    result[result.Length - 2] = func(source[result.Length - 2]);
                }
                result[result.Length - 1] = func(source[result.Length - 1]);
            }
            return result;
        }
                
        
        /// <summary>
        /// Map each element of source collection to an element of resulting array
        /// </summary>
        /// <typeparam name="T">Type of source collection</typeparam>
        /// <typeparam name="TResult">Type of result array</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="func">Function that maps elements from source collection to resulting collection</param>
        /// <returns>Array of mapped elements</returns>  
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        [NotNull]
        public static TResult[] SelectToArray<T, TResult>([NotNull] this List<T> source, [NotNull] Func<T, TResult> func)
        {
            source.IsNotNull(nameof(source));
            func.IsNotNull(nameof(func));
            var result = new TResult[source.Count];
            int i;
            for (i = 0; i < result.Length - Constants.Step + 1; i += Constants.Step)
            {
                TResult res1 = func(source[i]);
                TResult res2 = func(source[i + 1]);
                TResult res3 = func(source[i + 2]);
                TResult res4 = func(source[i + 3]);

                result[i] = res1;
                result[i + 1] = res2;
                result[i + 2] = res3;
                result[i + 3] = res4;
            }
            
            if (i <= result.Length - 1)
            {
                if (i <= result.Length - 2)
                {
                    if (i <= result.Length - 3)
                    {
                        result[result.Length - 3] = func(source[result.Length - 3]);
                    }
                    result[result.Length - 2] = func(source[result.Length - 2]);
                }
                result[result.Length - 1] = func(source[result.Length - 1]);
            }
            return result;
        }
                
        
        /// <summary>
        /// Map each element of source collection to an element of resulting array
        /// </summary>
        /// <typeparam name="T">Type of source collection</typeparam>
        /// <typeparam name="TResult">Type of result array</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="func">Function that maps elements from source collection to resulting collection</param>
        /// <returns>Array of mapped elements</returns>  
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        [NotNull]
        public static TResult[] SelectToArray<T, TResult>([NotNull] this IList<T> source, [NotNull] Func<T, TResult> func)
        {
            source.IsNotNull(nameof(source));
            func.IsNotNull(nameof(func));
            var result = new TResult[source.Count];
            int i;
            for (i = 0; i < result.Length - Constants.Step + 1; i += Constants.Step)
            {
                TResult res1 = func(source[i]);
                TResult res2 = func(source[i + 1]);
                TResult res3 = func(source[i + 2]);
                TResult res4 = func(source[i + 3]);

                result[i] = res1;
                result[i + 1] = res2;
                result[i + 2] = res3;
                result[i + 3] = res4;
            }
            
            if (i <= result.Length - 1)
            {
                if (i <= result.Length - 2)
                {
                    if (i <= result.Length - 3)
                    {
                        result[result.Length - 3] = func(source[result.Length - 3]);
                    }
                    result[result.Length - 2] = func(source[result.Length - 2]);
                }
                result[result.Length - 1] = func(source[result.Length - 1]);
            }
            return result;
        }
           

        /// <summary>
        /// Map each element of source collection to an element of resulting array
        /// </summary>
        /// <typeparam name="T">Type of source collection</typeparam>
        /// <typeparam name="TResult">Type of result array</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="func">Function that maps elements from source collection to resulting collection</param>
        /// <returns>Array of mapped elements</returns>       
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>   
        [Pure]
        [NotNull]
        public static TResult[] SelectToArray<T, TResult>([NotNull] this ICollection<T> source, [NotNull] Func<T, TResult> func)
        {
            source.IsNotNull(nameof(source));
            func.IsNotNull(nameof(func));
            var result = new TResult[source.Count];
            int i = 0;
            foreach (T value in source)
            {
                result[i++] = func(value);
            }
            return result;
        }      


		
        /// <summary>
        /// Map each element of source collection to an element of resulting list
        /// </summary>
        /// <typeparam name="T">Type of source collection</typeparam>
        /// <typeparam name="TResult">Type of result list</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="func">Function that maps elements from source collection to resulting collection</param>
        /// <returns>List of mapped elements</returns> 
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        [NotNull]
        public static List<TResult> SelectToList<T, TResult>([NotNull] this IEnumerable<T> source, [NotNull] Func<T, TResult> func)
        {
            //cannot check source here due to possible IEnumerable<T> multiple enumeration
            source.IsNotNull(nameof(source));
            func.IsNotNull(nameof(func));
            return SelectToList(source, func, Constants.ListDefaultCapacity);
        }
		
        /// <summary>
        /// Map each element of source collection to an element of resulting list
        /// </summary>
        /// <typeparam name="T">Type of source collection</typeparam>
        /// <typeparam name="TResult">Type of result list</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="func">Function that maps elements from source collection to resulting collection</param>
        /// <returns>List of mapped elements</returns> 
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        [NotNull]
        public static List<TResult> SelectToList<T, TResult>([NotNull] this ICollection<T> source, [NotNull] Func<T, TResult> func)
        {
            //cannot check source here due to possible IEnumerable<T> multiple enumeration
            source.IsNotNull(nameof(source));
            func.IsNotNull(nameof(func));
            return SelectToList(source, func, source.Count);
        }
		
        [Pure]
        [NotNull]
        private static List<TResult> SelectToList<T, TResult>([NotNull] this IEnumerable<T> source, [NotNull] Func<T, TResult> func, int count)
        {
            var list = new List<TResult>(count);
            foreach (var value in source)
                list.Add(func(value));
            return list;
        }
    }
}
