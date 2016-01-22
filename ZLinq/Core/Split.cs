using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using ZLinq.Extension;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
        #region Split
        /// <summary>
        /// Split array on several arrays which has specified size
        /// </summary>
        /// <typeparam name="T">Type of source and result arrays</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="size">Size of partitions</param>
        /// <returns>Enumeration of partitions</returns>
        [Pure]
        public static IEnumerable<T[]> Split<T>(this T[] source, int size)
        {
            source.IsNotNull("source");
            Guard.Requires<ArgumentException>(size > 0);
            for (int i = 0; i < source.Length; i += size)
            {
                T[] split = new T[Math.Min(size, source.Length - i)];
                Array.Copy(source, i, split, 0, split.Length);
                yield return split;
            }
        }

        /// <summary>
        /// Split array on several arrays which has specified size
        /// </summary>
        /// <typeparam name="T">Type of source and result arrays</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="size">Size of partitions</param>
        /// <returns>Enumeration of partitions</returns>
        [Pure]
        public static IEnumerable<T[]> Split<T>(this List<T> source, int size)
        {
            source.IsNotNull("source");
            Guard.Requires<ArgumentException>(size > 0);
            for (int i = 0; i < source.Count;)
            {
                T[] split = new T[Math.Min(size, source.Count - i)];
                for (int j = 0; j < split.Length; j++, i++)
                    split[j] = source[i];
                yield return split;
            }
        }

        /// <summary>
        /// Split array on several arrays which has specified size
        /// </summary>
        /// <typeparam name="T">Type of source and result arrays</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="size">Size of partitions</param>
        /// <returns>Enumeration of partitions</returns>
        [Pure]
        public static IEnumerable<T[]> Split<T>(this IList<T> source, int size)
        {
            source.IsNotNull("source");
            Guard.Requires<ArgumentException>(size > 0);
            for (int i = 0; i < source.Count;)
            {
                T[] split = new T[Math.Min(size, source.Count - i)];
                for (int j = 0; j < split.Length; j++, i++)
                    split[j] = source[i];
                yield return split;
            }
        }

        /// <summary>
        /// Split array on several arrays which has specified size
        /// </summary>
        /// <typeparam name="T">Type of source and result arrays</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="size">Size of partitions</param>
        /// <returns>Enumeration of partitions</returns>
        [Pure]
        public static IEnumerable<T[]> Split<T>(this ICollection<T> source, int size)
        {
            source.IsNotNull("source");
            Guard.Requires<ArgumentException>(size > 0);
            using (var enumerator = source.GetEnumerator())
            {
                int leftElmCount = source.Count;
                for (; leftElmCount > 0; leftElmCount -= size)
                {
                    T[] split = new T[Math.Min(size, leftElmCount)];
                    for (int i = 0; i < split.Length; i++)
                    {
                        enumerator.MoveNext();
                        split[i] = enumerator.Current;
                    }
                    yield return split;
                }
            }
        }

        /// <summary>
        /// Split array on several arrays which has specified size
        /// </summary>
        /// <typeparam name="T">Type of source and result arrays</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="size">Size of partitions</param>
        /// <returns>Enumeration of partitions</returns>
        [Pure]
        public static IEnumerable<T[]> Split<T>(this IEnumerable<T> source, int size)
        {
            Guard.Requires<ArgumentException>(size > 0);
            IEnumerator<T> enumerator;
            try
            {
                enumerator = source.GetEnumerator();
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("source", ex);
            }

            try
            {
                while (enumerator.MoveNext())
                {
                    T[] split = new T[size];
                    split[0] = enumerator.Current;
                    int i;
                    for (i = 1; i < split.Length && enumerator.MoveNext(); i++)
                    {
                        split[i] = enumerator.Current;
                    }
                    if (i < size)
                        Array.Resize(ref split, size);
                    yield return split;
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }

        #endregion

        #region SplitToArray

        /// <summary>
        /// Split array on several arrays which has specified size
        /// </summary>
        /// <typeparam name="T">Type of source and result arrays</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="size">Size of partitions</param>
        /// <returns>Array of partitions</returns>
        [Pure]
        public static T[][] SplitToArray<T>(this T[] source, int size)
        {
            source.IsNotNull("source");
            Guard.Requires<ArgumentException>(size > 0);
            T[][] result = new T[(int) Math.Ceiling((double) source.Length/size)][];
            Parallel.For(0, result.Length, k =>
                                           {
                                               int i = k*size;
                                               T[] split = new T[Math.Min(size, source.Length - i)];
                                               Array.Copy(source, i, split, 0, split.Length);
                                               result[k] = split;
                                           });
            return result;
        }

        /// <summary>
        /// Split array on several arrays which has specified size
        /// </summary>
        /// <typeparam name="T">Type of source and result arrays</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="size">Size of partitions</param>
        /// <returns>Array of partitions</returns>
        [Pure]
        public static T[][] SplitToArray<T>(this List<T> source, int size)
        {
            source.IsNotNull("source");
            Guard.Requires<ArgumentException>(size > 0);
            T[][] result = new T[(int) Math.Ceiling((double) source.Count/size)][];
            Parallel.For(0, result.Length, k =>
                                           {
                                               int i = k*size;
                                               T[] split = new T[Math.Min(size, source.Count - i)];
                                               for (int j = 0; j < split.Length; j++, i++)
                                                   split[j] = source[i];
                                               result[k] = split;
                                           });
            return result;
        }

        /// <summary>
        /// Split array on several arrays which has specified size
        /// </summary>
        /// <typeparam name="T">Type of source and result arrays</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="size">Size of partitions</param>
        /// <returns>Array of partitions</returns>
        [Pure]
        public static T[][] SplitToArray<T>(this IList<T> source, int size)
        {
            source.IsNotNull("source");
            Guard.Requires<ArgumentException>(size > 0);
            T[][] result = new T[(int) Math.Ceiling((double) source.Count/size)][];
            Parallel.For(0, result.Length, k =>
                                           {
                                               int i = k*size;
                                               T[] split = new T[Math.Min(size, source.Count - i)];
                                               for (int j = 0; j < split.Length; j++, i++)
                                                   split[j] = source[i];
                                               result[k] = split;
                                           });
            return result;
        }

        /// <summary>
        /// Split array on several arrays which has specified size
        /// </summary>
        /// <typeparam name="T">Type of source and result arrays</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="size">Size of partitions</param>
        /// <returns>Array of partitions</returns>
        [Pure]
        public static T[][] SplitToArray<T>(this ICollection<T> source, int size)
        {
            return source.Split(size).ToArray();
        }

        /// <summary>
        /// Split array on several arrays which has specified size
        /// </summary>
        /// <typeparam name="T">Type of source and result arrays</typeparam>
        /// <param name="source">Source collection</param>
        /// <param name="size">Size of partitions</param>
        /// <returns>Array of partitions</returns>
        [Pure]
        public static IEnumerable<T[]> SplitToArray<T>(this IEnumerable<T> source, int size)
        {
            return source.Split(size).ToArray();
        }

        #endregion

    }
}