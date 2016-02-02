
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using ZLinq.Extension;

// ReSharper disable CheckNamespace
// ReSharper disable RedundantCast
namespace ZLinq
{
    public static partial class ZEnumerable
    {        
    
        #region sbyte             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this sbyte[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<sbyte> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<sbyte> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region byte             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this byte[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<byte> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<byte> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region short             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this short[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<short> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<short> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region ushort             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this ushort[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<ushort> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<ushort> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region int             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this int[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<int> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<int> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region uint             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this uint[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<uint> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<uint> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region long             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this long[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<long> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<long> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region float             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this float[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<float> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<float> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region double             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this double[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<double> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<double> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region decimal             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this decimal[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<decimal> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<decimal> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region ulong             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this ulong[] source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Length);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Length;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<ulong> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<ulong> source)
        {
            source.IsNotNull("source");
            try
            {
                double sum = (double) source.Sum();
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(x => (double) x*mult);
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            try
            {
                double sum = (double) source.Sum(mapFunc);
                return (sum/source.Count);
            }
            catch (OverflowException)
            {
                double mult = (double) 1.0/source.Count;
                return source.Sum(arg => (double) mapFunc(arg)*mult);
            }
        }

        
        #endregion
        
    }
}
