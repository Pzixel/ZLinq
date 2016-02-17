
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using ZLinq.Common;
using ZLinq.CommonInternal;

// ReSharper disable CheckNamespace
// ReSharper disable RedundantCast
namespace ZLinq
{
    public static partial class ZEnumerable
    {        
    
        #region sbyte             
            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this sbyte[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<sbyte[], sbyte>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<sbyte> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<sbyte>, sbyte>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<sbyte> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<sbyte>, sbyte>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region byte             
            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this byte[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<byte[], byte>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<byte> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<byte>, byte>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<byte> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<byte>, byte>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region short             
            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this short[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<short[], short>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<short> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<short>, short>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<short> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<short>, short>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region ushort             
            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this ushort[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<ushort[], ushort>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<ushort> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<ushort>, ushort>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<ushort> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<ushort>, ushort>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region int             
            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this int[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<int[], int>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<int> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<int>, int>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<int> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<int>, int>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region uint             
            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this uint[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<uint[], uint>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<uint> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<uint>, uint>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<uint> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<uint>, uint>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region long             
            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this long[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<long[], long>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<long> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<long>, long>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<long> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<long>, long>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region ulong             
            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this ulong[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<ulong[], ulong>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<ulong> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<ulong>, ulong>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<ulong> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<ulong>, ulong>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => x*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => mapFunc(arg)*mult);
            }
        }

        
        #endregion
    
        #region sbyte?             
            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this sbyte?[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<sbyte?[], sbyte?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<sbyte?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<sbyte?>, sbyte?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<sbyte?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<sbyte?>, sbyte?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

        
        #endregion
    
        #region byte?             
            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this byte?[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<byte?[], byte?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<byte?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<byte?>, byte?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<byte?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<byte?>, byte?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

        
        #endregion
    
        #region short?             
            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this short?[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<short?[], short?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<short?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<short?>, short?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<short?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<short?>, short?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

        
        #endregion
    
        #region ushort?             
            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this ushort?[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<ushort?[], ushort?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<ushort?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<ushort?>, ushort?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<ushort?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<ushort?>, ushort?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

        
        #endregion
    
        #region int?             
            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this int?[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<int?[], int?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<int?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<int?>, int?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<int?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<int?>, int?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

        
        #endregion
    
        #region uint?             
            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this uint?[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<uint?[], uint?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<uint?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<uint?>, uint?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<uint?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<uint?>, uint?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

        
        #endregion
    
        #region long?             
            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this long?[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<long?[], long?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<long?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<long?>, long?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<long?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<long?>, long?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

        
        #endregion
    
        #region ulong?             
            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this ulong?[] source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<ulong?[], ulong?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Length;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Length;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Length;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<ulong?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<List<ulong?>, ulong?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

            
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<ulong?> source)
        {   
            source.IsNotNull("source");
            source.IsNotEmpty<IList<ulong?>, ulong?>();
            try
            {
                double sum = source.Sum();
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
            catch (AggregateException ex)
            {                
                if (!(ex.InnerException is OverflowException))
                    throw;                
                double mult = 1.0/source.Count;
                return source.Sum(x => (x ?? 0)*mult);
            }
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            try
            {
                double sum = source.Sum(mapFunc);
                return sum/source.Count;
            }
            catch (OverflowException)
            {
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
            catch (AggregateException ex)
            {
                if (!(ex.InnerException is OverflowException))
                    throw;
                double mult = 1.0/source.Count;
                return source.Sum(arg => (mapFunc(arg) ?? 0)*mult);
            }
        }

        
        #endregion
        

       
        #region float             
          
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this float[] source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<float[], float>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(x => (double) x*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(arg => (double) mapFunc(arg)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<float> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<List<float>, float>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) x*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) mapFunc(arg)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<float> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<IList<float>, float>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) x*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) mapFunc(arg)*mult);
        }

        
        #endregion
    
        #region double             
          
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this double[] source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<double[], double>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(x => (double) x*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(arg => (double) mapFunc(arg)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<double> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<List<double>, double>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) x*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) mapFunc(arg)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<double> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<IList<double>, double>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) x*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) mapFunc(arg)*mult);
        }

        
        #endregion
    
        #region decimal             
          
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this decimal[] source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<decimal[], decimal>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(x => (double) x*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(arg => (double) mapFunc(arg)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<decimal> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<List<decimal>, decimal>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) x*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) mapFunc(arg)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<decimal> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<IList<decimal>, decimal>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) x*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping 
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) mapFunc(arg)*mult);
        }

        
        #endregion
    
        #region float?             
          
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this float?[] source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<float?[], float?>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(x => (double) (x ?? 0)*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(arg => (double) (mapFunc(arg) ?? 0)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<float?> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<List<float?>, float?>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) (x ?? 0)*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) (mapFunc(arg) ?? 0)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<float?> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<IList<float?>, float?>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) (x ?? 0)*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) (mapFunc(arg) ?? 0)*mult);
        }

        
        #endregion
    
        #region double?             
          
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this double?[] source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<double?[], double?>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(x => (double) (x ?? 0)*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(arg => (double) (mapFunc(arg) ?? 0)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<double?> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<List<double?>, double?>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) (x ?? 0)*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) (mapFunc(arg) ?? 0)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<double?> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<IList<double?>, double?>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) (x ?? 0)*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) (mapFunc(arg) ?? 0)*mult);
        }

        
        #endregion
    
        #region decimal?             
          
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this decimal?[] source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<decimal?[], decimal?>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(x => (double) (x ?? 0)*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this T[] source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<T[], T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Length;
            }
            double mult = 1.0/source.Length;
            return source.Sum(arg => (double) (mapFunc(arg) ?? 0)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this List<decimal?> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<List<decimal?>, decimal?>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) (x ?? 0)*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<List<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) (mapFunc(arg) ?? 0)*mult);
        }

          
        /// <summary>
        /// Calculates average of collection . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average([NotNull] this IList<decimal?> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<IList<decimal?>, decimal?>();
            double sum = (double) source.Sum();
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(x => (double) (x ?? 0)*mult);
        }

        /// <summary>
        /// Calculates average of collection mapping . Nulls are treated as 0
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Average of all elements</returns>
        [Pure]
        public static double Average<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            source.IsNotEmpty<IList<T>, T>();
            double sum = (double) source.Sum(mapFunc);
            if (!double.IsInfinity(sum))
            {
               return sum/source.Count;
            }
            double mult = 1.0/source.Count;
            return source.Sum(arg => (double) (mapFunc(arg) ?? 0)*mult);
        }

        
        #endregion
        
    }
}
