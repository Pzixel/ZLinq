using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
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
            if (result.Length <= Constants.SingleThreadExecutionThreshold)
            {
				SelectToArray(source, result, func, 0, result.Length);
            }
            else
            {                
                Parallel.ForEach(Partitioner.Create(0, result.Length),
                                 range => 
								 { 
									SelectToArray(source, result, func, range.Item1, range.Item2); 
								 });
            }
            return result;
        }

        private static void SelectToArray<T, TResult>([NotNull] this T[] source, TResult[] result, [NotNull] Func<T, TResult> func, int start, int end)
        {
            int i;
			int loopEnd = end - Constants.Step + 1;
            for (i = start; i < loopEnd; i += Constants.Step)
            {
                result[i] = func(source[i]);
                result[i + 1] = func(source[i + 1]);
                result[i + 2] = func(source[i + 2]);
                result[i + 3] = func(source[i + 3]);
            }

            if (i <= end - 1)
            {
                if (i <= end - 2)
                {
                    if (i <= end - 3)
                    {
                        result[end - 3] = func(source[end - 3]);
                    }
                    result[end - 2] = func(source[end - 2]);
                }
                result[end - 1] = func(source[end - 1]);
            }
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
            if (result.Length <= Constants.SingleThreadExecutionThreshold)
            {
				SelectToArray(source, result, func, 0, result.Length);
            }
            else
            {                
                Parallel.ForEach(Partitioner.Create(0, result.Length),
                                 range => 
								 { 
									SelectToArray(source, result, func, range.Item1, range.Item2); 
								 });
            }
            return result;
        }

        private static void SelectToArray<T, TResult>([NotNull] this List<T> source, TResult[] result, [NotNull] Func<T, TResult> func, int start, int end)
        {
            int i;
			int loopEnd = end - Constants.Step + 1;
            for (i = start; i < loopEnd; i += Constants.Step)
            {
                result[i] = func(source[i]);
                result[i + 1] = func(source[i + 1]);
                result[i + 2] = func(source[i + 2]);
                result[i + 3] = func(source[i + 3]);
            }

            if (i <= end - 1)
            {
                if (i <= end - 2)
                {
                    if (i <= end - 3)
                    {
                        result[end - 3] = func(source[end - 3]);
                    }
                    result[end - 2] = func(source[end - 2]);
                }
                result[end - 1] = func(source[end - 1]);
            }
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
            if (result.Length <= Constants.SingleThreadExecutionThreshold)
            {
				SelectToArray(source, result, func, 0, result.Length);
            }
            else
            {                
                Parallel.ForEach(Partitioner.Create(0, result.Length),
                                 range => 
								 { 
									SelectToArray(source, result, func, range.Item1, range.Item2); 
								 });
            }
            return result;
        }

        private static void SelectToArray<T, TResult>([NotNull] this IList<T> source, TResult[] result, [NotNull] Func<T, TResult> func, int start, int end)
        {
            int i;
			int loopEnd = end - Constants.Step + 1;
            for (i = start; i < loopEnd; i += Constants.Step)
            {
                result[i] = func(source[i]);
                result[i + 1] = func(source[i + 1]);
                result[i + 2] = func(source[i + 2]);
                result[i + 3] = func(source[i + 3]);
            }

            if (i <= end - 1)
            {
                if (i <= end - 2)
                {
                    if (i <= end - 3)
                    {
                        result[end - 3] = func(source[end - 3]);
                    }
                    result[end - 2] = func(source[end - 2]);
                }
                result[end - 1] = func(source[end - 1]);
            }
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
