
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using JetBrains.Annotations;
using ZLinq.Common;
using ZLinq.CommonInternal;


// ReSharper disable CheckNamespace 
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum([NotNull] this sbyte[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum([NotNull] this sbyte[] source, int startIndex, int endIndex)
        {
            sbyte sum0 = 0;
            sbyte sum1 = 0;
            sbyte sum2 = 0;
            sbyte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            sbyte sum0 = 0;
            sbyte sum1 = 0;
            sbyte sum2 = 0;
            sbyte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum([NotNull] this List<sbyte> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum([NotNull] this List<sbyte> source, int startIndex, int endIndex)
        {
            sbyte sum0 = 0;
            sbyte sum1 = 0;
            sbyte sum2 = 0;
            sbyte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            sbyte sum0 = 0;
            sbyte sum1 = 0;
            sbyte sum2 = 0;
            sbyte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum([NotNull] this IList<sbyte> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum([NotNull] this IList<sbyte> source, int startIndex, int endIndex)
        {
            sbyte sum0 = 0;
            sbyte sum1 = 0;
            sbyte sum2 = 0;
            sbyte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            sbyte sum0 = 0;
            sbyte sum1 = 0;
            sbyte sum2 = 0;
            sbyte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region byte             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum([NotNull] this byte[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum([NotNull] this byte[] source, int startIndex, int endIndex)
        {
            byte sum0 = 0;
            byte sum1 = 0;
            byte sum2 = 0;
            byte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum<T>([NotNull] this T[] source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum<T>([NotNull] this T[] source, [NotNull] Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            byte sum0 = 0;
            byte sum1 = 0;
            byte sum2 = 0;
            byte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum([NotNull] this List<byte> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum([NotNull] this List<byte> source, int startIndex, int endIndex)
        {
            byte sum0 = 0;
            byte sum1 = 0;
            byte sum2 = 0;
            byte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            byte sum0 = 0;
            byte sum1 = 0;
            byte sum2 = 0;
            byte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum([NotNull] this IList<byte> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum([NotNull] this IList<byte> source, int startIndex, int endIndex)
        {
            byte sum0 = 0;
            byte sum1 = 0;
            byte sum2 = 0;
            byte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            byte sum0 = 0;
            byte sum1 = 0;
            byte sum2 = 0;
            byte sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region short             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum([NotNull] this short[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum([NotNull] this short[] source, int startIndex, int endIndex)
        {
            short sum0 = 0;
            short sum1 = 0;
            short sum2 = 0;
            short sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (short) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum<T>([NotNull] this T[] source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum<T>([NotNull] this T[] source, [NotNull] Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            short sum0 = 0;
            short sum1 = 0;
            short sum2 = 0;
            short sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum([NotNull] this List<short> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum([NotNull] this List<short> source, int startIndex, int endIndex)
        {
            short sum0 = 0;
            short sum1 = 0;
            short sum2 = 0;
            short sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (short) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            short sum0 = 0;
            short sum1 = 0;
            short sum2 = 0;
            short sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum([NotNull] this IList<short> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum([NotNull] this IList<short> source, int startIndex, int endIndex)
        {
            short sum0 = 0;
            short sum1 = 0;
            short sum2 = 0;
            short sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (short) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            short sum0 = 0;
            short sum1 = 0;
            short sum2 = 0;
            short sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region ushort             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum([NotNull] this ushort[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum([NotNull] this ushort[] source, int startIndex, int endIndex)
        {
            ushort sum0 = 0;
            ushort sum1 = 0;
            ushort sum2 = 0;
            ushort sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum<T>([NotNull] this T[] source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum<T>([NotNull] this T[] source, [NotNull] Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            ushort sum0 = 0;
            ushort sum1 = 0;
            ushort sum2 = 0;
            ushort sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum([NotNull] this List<ushort> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum([NotNull] this List<ushort> source, int startIndex, int endIndex)
        {
            ushort sum0 = 0;
            ushort sum1 = 0;
            ushort sum2 = 0;
            ushort sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            ushort sum0 = 0;
            ushort sum1 = 0;
            ushort sum2 = 0;
            ushort sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum([NotNull] this IList<ushort> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum([NotNull] this IList<ushort> source, int startIndex, int endIndex)
        {
            ushort sum0 = 0;
            ushort sum1 = 0;
            ushort sum2 = 0;
            ushort sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            ushort sum0 = 0;
            ushort sum1 = 0;
            ushort sum2 = 0;
            ushort sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region int             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum([NotNull] this int[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum([NotNull] this int[] source, int startIndex, int endIndex)
        {
            int sum0 = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (int) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum<T>([NotNull] this T[] source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum<T>([NotNull] this T[] source, [NotNull] Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int sum0 = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum([NotNull] this List<int> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum([NotNull] this List<int> source, int startIndex, int endIndex)
        {
            int sum0 = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (int) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int sum0 = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum([NotNull] this IList<int> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum([NotNull] this IList<int> source, int startIndex, int endIndex)
        {
            int sum0 = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (int) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int sum0 = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region uint             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum([NotNull] this uint[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum([NotNull] this uint[] source, int startIndex, int endIndex)
        {
            uint sum0 = 0;
            uint sum1 = 0;
            uint sum2 = 0;
            uint sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum<T>([NotNull] this T[] source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum<T>([NotNull] this T[] source, [NotNull] Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            uint sum0 = 0;
            uint sum1 = 0;
            uint sum2 = 0;
            uint sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum([NotNull] this List<uint> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum([NotNull] this List<uint> source, int startIndex, int endIndex)
        {
            uint sum0 = 0;
            uint sum1 = 0;
            uint sum2 = 0;
            uint sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            uint sum0 = 0;
            uint sum1 = 0;
            uint sum2 = 0;
            uint sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum([NotNull] this IList<uint> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum([NotNull] this IList<uint> source, int startIndex, int endIndex)
        {
            uint sum0 = 0;
            uint sum1 = 0;
            uint sum2 = 0;
            uint sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            uint sum0 = 0;
            uint sum1 = 0;
            uint sum2 = 0;
            uint sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region long             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum([NotNull] this long[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum([NotNull] this long[] source, int startIndex, int endIndex)
        {
            long sum0 = 0;
            long sum1 = 0;
            long sum2 = 0;
            long sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (long) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum<T>([NotNull] this T[] source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum<T>([NotNull] this T[] source, [NotNull] Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            long sum0 = 0;
            long sum1 = 0;
            long sum2 = 0;
            long sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum([NotNull] this List<long> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum([NotNull] this List<long> source, int startIndex, int endIndex)
        {
            long sum0 = 0;
            long sum1 = 0;
            long sum2 = 0;
            long sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (long) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            long sum0 = 0;
            long sum1 = 0;
            long sum2 = 0;
            long sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum([NotNull] this IList<long> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum([NotNull] this IList<long> source, int startIndex, int endIndex)
        {
            long sum0 = 0;
            long sum1 = 0;
            long sum2 = 0;
            long sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (long) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            long sum0 = 0;
            long sum1 = 0;
            long sum2 = 0;
            long sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region ulong             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum([NotNull] this ulong[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum([NotNull] this ulong[] source, int startIndex, int endIndex)
        {
            ulong sum0 = 0;
            ulong sum1 = 0;
            ulong sum2 = 0;
            ulong sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum<T>([NotNull] this T[] source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum<T>([NotNull] this T[] source, [NotNull] Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            ulong sum0 = 0;
            ulong sum1 = 0;
            ulong sum2 = 0;
            ulong sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum([NotNull] this List<ulong> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum([NotNull] this List<ulong> source, int startIndex, int endIndex)
        {
            ulong sum0 = 0;
            ulong sum1 = 0;
            ulong sum2 = 0;
            ulong sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            ulong sum0 = 0;
            ulong sum1 = 0;
            ulong sum2 = 0;
            ulong sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum([NotNull] this IList<ulong> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum([NotNull] this IList<ulong> source, int startIndex, int endIndex)
        {
            ulong sum0 = 0;
            ulong sum1 = 0;
            ulong sum2 = 0;
            ulong sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            ulong sum0 = 0;
            ulong sum1 = 0;
            ulong sum2 = 0;
            ulong sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region float             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum([NotNull] this float[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum([NotNull] this float[] source, int startIndex, int endIndex)
        {
            float sum0 = 0;
            float sum1 = 0;
            float sum2 = 0;
            float sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (float) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum<T>([NotNull] this T[] source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum<T>([NotNull] this T[] source, [NotNull] Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            float sum0 = 0;
            float sum1 = 0;
            float sum2 = 0;
            float sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum([NotNull] this List<float> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum([NotNull] this List<float> source, int startIndex, int endIndex)
        {
            float sum0 = 0;
            float sum1 = 0;
            float sum2 = 0;
            float sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (float) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            float sum0 = 0;
            float sum1 = 0;
            float sum2 = 0;
            float sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum([NotNull] this IList<float> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum([NotNull] this IList<float> source, int startIndex, int endIndex)
        {
            float sum0 = 0;
            float sum1 = 0;
            float sum2 = 0;
            float sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (float) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            float sum0 = 0;
            float sum1 = 0;
            float sum2 = 0;
            float sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region double             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum([NotNull] this double[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum([NotNull] this double[] source, int startIndex, int endIndex)
        {
            double sum0 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (double) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum<T>([NotNull] this T[] source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum<T>([NotNull] this T[] source, [NotNull] Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            double sum0 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum([NotNull] this List<double> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum([NotNull] this List<double> source, int startIndex, int endIndex)
        {
            double sum0 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (double) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            double sum0 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum([NotNull] this IList<double> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum([NotNull] this IList<double> source, int startIndex, int endIndex)
        {
            double sum0 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (double) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            double sum0 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region decimal             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum([NotNull] this decimal[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum([NotNull] this decimal[] source, int startIndex, int endIndex)
        {
            decimal sum0 = 0;
            decimal sum1 = 0;
            decimal sum2 = 0;
            decimal sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum<T>([NotNull] this T[] source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum<T>([NotNull] this T[] source, [NotNull] Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            decimal sum0 = 0;
            decimal sum1 = 0;
            decimal sum2 = 0;
            decimal sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum([NotNull] this List<decimal> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum([NotNull] this List<decimal> source, int startIndex, int endIndex)
        {
            decimal sum0 = 0;
            decimal sum1 = 0;
            decimal sum2 = 0;
            decimal sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            decimal sum0 = 0;
            decimal sum1 = 0;
            decimal sum2 = 0;
            decimal sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum([NotNull] this IList<decimal> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum([NotNull] this IList<decimal> source, int startIndex, int endIndex)
        {
            decimal sum0 = 0;
            decimal sum1 = 0;
            decimal sum2 = 0;
            decimal sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1]);
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i] + source[i+1] + source[i+2]);
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            decimal sum0 = 0;
            decimal sum1 = 0;
            decimal sum2 = 0;
            decimal sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]));
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i+1]) + mapFunc(source[i+2]));
            }
        }
                
        #endregion
    
        #region sbyte?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum([NotNull] this sbyte?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum([NotNull] this sbyte?[] source, int startIndex, int endIndex)
        {
            sbyte? sum0 = 0;
            sbyte? sum1 = 0;
            sbyte? sum2 = 0;
            sbyte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
            sbyte? sum0 = 0;
            sbyte? sum1 = 0;
            sbyte? sum2 = 0;
            sbyte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum([NotNull] this List<sbyte?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum([NotNull] this List<sbyte?> source, int startIndex, int endIndex)
        {
            sbyte? sum0 = 0;
            sbyte? sum1 = 0;
            sbyte? sum2 = 0;
            sbyte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
            sbyte? sum0 = 0;
            sbyte? sum1 = 0;
            sbyte? sum2 = 0;
            sbyte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum([NotNull] this IList<sbyte?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum([NotNull] this IList<sbyte?> source, int startIndex, int endIndex)
        {
            sbyte? sum0 = 0;
            sbyte? sum1 = 0;
            sbyte? sum2 = 0;
            sbyte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static sbyte Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static sbyte Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
            sbyte? sum0 = 0;
            sbyte? sum1 = 0;
            sbyte? sum2 = 0;
            sbyte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (sbyte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
    
        #region byte?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum([NotNull] this byte?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum([NotNull] this byte?[] source, int startIndex, int endIndex)
        {
            byte? sum0 = 0;
            byte? sum1 = 0;
            byte? sum2 = 0;
            byte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum<T>([NotNull] this T[] source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum<T>([NotNull] this T[] source, [NotNull] Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
            byte? sum0 = 0;
            byte? sum1 = 0;
            byte? sum2 = 0;
            byte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum([NotNull] this List<byte?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum([NotNull] this List<byte?> source, int startIndex, int endIndex)
        {
            byte? sum0 = 0;
            byte? sum1 = 0;
            byte? sum2 = 0;
            byte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
            byte? sum0 = 0;
            byte? sum1 = 0;
            byte? sum2 = 0;
            byte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum([NotNull] this IList<byte?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum([NotNull] this IList<byte?> source, int startIndex, int endIndex)
        {
            byte? sum0 = 0;
            byte? sum1 = 0;
            byte? sum2 = 0;
            byte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (byte) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static byte Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static byte Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
            byte? sum0 = 0;
            byte? sum1 = 0;
            byte? sum2 = 0;
            byte? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (byte) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (byte) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
    
        #region short?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum([NotNull] this short?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum([NotNull] this short?[] source, int startIndex, int endIndex)
        {
            short? sum0 = 0;
            short? sum1 = 0;
            short? sum2 = 0;
            short? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (short) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum<T>([NotNull] this T[] source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum<T>([NotNull] this T[] source, [NotNull] Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
            short? sum0 = 0;
            short? sum1 = 0;
            short? sum2 = 0;
            short? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum([NotNull] this List<short?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum([NotNull] this List<short?> source, int startIndex, int endIndex)
        {
            short? sum0 = 0;
            short? sum1 = 0;
            short? sum2 = 0;
            short? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (short) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
            short? sum0 = 0;
            short? sum1 = 0;
            short? sum2 = 0;
            short? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum([NotNull] this IList<short?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum([NotNull] this IList<short?> source, int startIndex, int endIndex)
        {
            short? sum0 = 0;
            short? sum1 = 0;
            short? sum2 = 0;
            short? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (short) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static short Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            short result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static short Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
            short? sum0 = 0;
            short? sum1 = 0;
            short? sum2 = 0;
            short? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (short) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (short) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
    
        #region ushort?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum([NotNull] this ushort?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum([NotNull] this ushort?[] source, int startIndex, int endIndex)
        {
            ushort? sum0 = 0;
            ushort? sum1 = 0;
            ushort? sum2 = 0;
            ushort? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum<T>([NotNull] this T[] source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum<T>([NotNull] this T[] source, [NotNull] Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
            ushort? sum0 = 0;
            ushort? sum1 = 0;
            ushort? sum2 = 0;
            ushort? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum([NotNull] this List<ushort?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum([NotNull] this List<ushort?> source, int startIndex, int endIndex)
        {
            ushort? sum0 = 0;
            ushort? sum1 = 0;
            ushort? sum2 = 0;
            ushort? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
            ushort? sum0 = 0;
            ushort? sum1 = 0;
            ushort? sum2 = 0;
            ushort? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum([NotNull] this IList<ushort?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum([NotNull] this IList<ushort?> source, int startIndex, int endIndex)
        {
            ushort? sum0 = 0;
            ushort? sum1 = 0;
            ushort? sum2 = 0;
            ushort? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ushort Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ushort Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
            ushort? sum0 = 0;
            ushort? sum1 = 0;
            ushort? sum2 = 0;
            ushort? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (ushort) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
    
        #region int?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum([NotNull] this int?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum([NotNull] this int?[] source, int startIndex, int endIndex)
        {
            int? sum0 = 0;
            int? sum1 = 0;
            int? sum2 = 0;
            int? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (int) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum<T>([NotNull] this T[] source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum<T>([NotNull] this T[] source, [NotNull] Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
            int? sum0 = 0;
            int? sum1 = 0;
            int? sum2 = 0;
            int? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum([NotNull] this List<int?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum([NotNull] this List<int?> source, int startIndex, int endIndex)
        {
            int? sum0 = 0;
            int? sum1 = 0;
            int? sum2 = 0;
            int? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (int) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
            int? sum0 = 0;
            int? sum1 = 0;
            int? sum2 = 0;
            int? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum([NotNull] this IList<int?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum([NotNull] this IList<int?> source, int startIndex, int endIndex)
        {
            int? sum0 = 0;
            int? sum1 = 0;
            int? sum2 = 0;
            int? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (int) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static int Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            int result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static int Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
            int? sum0 = 0;
            int? sum1 = 0;
            int? sum2 = 0;
            int? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
    
        #region uint?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum([NotNull] this uint?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum([NotNull] this uint?[] source, int startIndex, int endIndex)
        {
            uint? sum0 = 0;
            uint? sum1 = 0;
            uint? sum2 = 0;
            uint? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum<T>([NotNull] this T[] source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum<T>([NotNull] this T[] source, [NotNull] Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
            uint? sum0 = 0;
            uint? sum1 = 0;
            uint? sum2 = 0;
            uint? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum([NotNull] this List<uint?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum([NotNull] this List<uint?> source, int startIndex, int endIndex)
        {
            uint? sum0 = 0;
            uint? sum1 = 0;
            uint? sum2 = 0;
            uint? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
            uint? sum0 = 0;
            uint? sum1 = 0;
            uint? sum2 = 0;
            uint? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum([NotNull] this IList<uint?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum([NotNull] this IList<uint?> source, int startIndex, int endIndex)
        {
            uint? sum0 = 0;
            uint? sum1 = 0;
            uint? sum2 = 0;
            uint? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (uint) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static uint Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static uint Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
            uint? sum0 = 0;
            uint? sum1 = 0;
            uint? sum2 = 0;
            uint? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (uint) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (uint) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
    
        #region long?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum([NotNull] this long?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum([NotNull] this long?[] source, int startIndex, int endIndex)
        {
            long? sum0 = 0;
            long? sum1 = 0;
            long? sum2 = 0;
            long? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (long) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum<T>([NotNull] this T[] source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum<T>([NotNull] this T[] source, [NotNull] Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
            long? sum0 = 0;
            long? sum1 = 0;
            long? sum2 = 0;
            long? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum([NotNull] this List<long?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum([NotNull] this List<long?> source, int startIndex, int endIndex)
        {
            long? sum0 = 0;
            long? sum1 = 0;
            long? sum2 = 0;
            long? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (long) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
            long? sum0 = 0;
            long? sum1 = 0;
            long? sum2 = 0;
            long? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum([NotNull] this IList<long?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum([NotNull] this IList<long?> source, int startIndex, int endIndex)
        {
            long? sum0 = 0;
            long? sum1 = 0;
            long? sum2 = 0;
            long? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (long) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static long Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            long result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static long Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
            long? sum0 = 0;
            long? sum1 = 0;
            long? sum2 = 0;
            long? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (long) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (long) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
    
        #region ulong?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum([NotNull] this ulong?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum([NotNull] this ulong?[] source, int startIndex, int endIndex)
        {
            ulong? sum0 = 0;
            ulong? sum1 = 0;
            ulong? sum2 = 0;
            ulong? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum<T>([NotNull] this T[] source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum<T>([NotNull] this T[] source, [NotNull] Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
            ulong? sum0 = 0;
            ulong? sum1 = 0;
            ulong? sum2 = 0;
            ulong? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum([NotNull] this List<ulong?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum([NotNull] this List<ulong?> source, int startIndex, int endIndex)
        {
            ulong? sum0 = 0;
            ulong? sum1 = 0;
            ulong? sum2 = 0;
            ulong? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
            ulong? sum0 = 0;
            ulong? sum1 = 0;
            ulong? sum2 = 0;
            ulong? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum([NotNull] this IList<ulong?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum([NotNull] this IList<ulong?> source, int startIndex, int endIndex)
        {
            ulong? sum0 = 0;
            ulong? sum1 = 0;
            ulong? sum2 = 0;
            ulong? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static ulong Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static ulong Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
            ulong? sum0 = 0;
            ulong? sum1 = 0;
            ulong? sum2 = 0;
            ulong? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (ulong) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
    
        #region float?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum([NotNull] this float?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum([NotNull] this float?[] source, int startIndex, int endIndex)
        {
            float? sum0 = 0;
            float? sum1 = 0;
            float? sum2 = 0;
            float? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (float) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum<T>([NotNull] this T[] source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum<T>([NotNull] this T[] source, [NotNull] Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
            float? sum0 = 0;
            float? sum1 = 0;
            float? sum2 = 0;
            float? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum([NotNull] this List<float?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum([NotNull] this List<float?> source, int startIndex, int endIndex)
        {
            float? sum0 = 0;
            float? sum1 = 0;
            float? sum2 = 0;
            float? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (float) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
            float? sum0 = 0;
            float? sum1 = 0;
            float? sum2 = 0;
            float? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum([NotNull] this IList<float?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum([NotNull] this IList<float?> source, int startIndex, int endIndex)
        {
            float? sum0 = 0;
            float? sum1 = 0;
            float? sum2 = 0;
            float? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (float) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static float Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            float result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static float Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
            float? sum0 = 0;
            float? sum1 = 0;
            float? sum2 = 0;
            float? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (float) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (float) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
    
        #region double?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum([NotNull] this double?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum([NotNull] this double?[] source, int startIndex, int endIndex)
        {
            double? sum0 = 0;
            double? sum1 = 0;
            double? sum2 = 0;
            double? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (double) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum<T>([NotNull] this T[] source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum<T>([NotNull] this T[] source, [NotNull] Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
            double? sum0 = 0;
            double? sum1 = 0;
            double? sum2 = 0;
            double? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum([NotNull] this List<double?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum([NotNull] this List<double?> source, int startIndex, int endIndex)
        {
            double? sum0 = 0;
            double? sum1 = 0;
            double? sum2 = 0;
            double? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (double) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
            double? sum0 = 0;
            double? sum1 = 0;
            double? sum2 = 0;
            double? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum([NotNull] this IList<double?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum([NotNull] this IList<double?> source, int startIndex, int endIndex)
        {
            double? sum0 = 0;
            double? sum1 = 0;
            double? sum2 = 0;
            double? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (double) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static double Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            double result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static double Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
            double? sum0 = 0;
            double? sum1 = 0;
            double? sum2 = 0;
            double? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (double) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (double) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
    
        #region decimal?             
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum([NotNull] this decimal?[] source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum([NotNull] this decimal?[] source, int startIndex, int endIndex)
        {
            decimal? sum0 = 0;
            decimal? sum1 = 0;
            decimal? sum2 = 0;
            decimal? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum<T>([NotNull] this T[] source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum<T>([NotNull] this T[] source, [NotNull] Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
            decimal? sum0 = 0;
            decimal? sum1 = 0;
            decimal? sum2 = 0;
            decimal? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum([NotNull] this List<decimal?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum([NotNull] this List<decimal?> source, int startIndex, int endIndex)
        {
            decimal? sum0 = 0;
            decimal? sum1 = 0;
            decimal? sum2 = 0;
            decimal? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
            decimal? sum0 = 0;
            decimal? sum1 = 0;
            decimal? sum2 = 0;
            decimal? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                    
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum([NotNull] this IList<decimal?> source)
        {
            source.IsNotNull(nameof(source));
            
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum([NotNull] this IList<decimal?> source, int startIndex, int endIndex)
        {
            decimal? sum0 = 0;
            decimal? sum1 = 0;
            decimal? sum2 = 0;
            decimal? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0].GetValueOrDefault();
                    sum1 += source[i + 1].GetValueOrDefault();
                    sum2 += source[i + 2].GetValueOrDefault();
                    sum3 += source[i + 3].GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault());
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + source[i].GetValueOrDefault() + source[i+1].GetValueOrDefault() + source[i+2].GetValueOrDefault());
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
/// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Sum of all elements</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="OverflowException">Throws when result value is bigger than MaxValue</exception>
        [Pure]
        public static decimal Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();  
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, mapFunc, range.Item1, range.Item2);
                        checked
                        {   
                            lock (syncRoot)
                                result += x;  
                        }     
                    });   

            return result;
        }

        [Pure]
        private static decimal Sum<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
            decimal? sum0 = 0;
            decimal? sum1 = 0;
            decimal? sum2 = 0;
            decimal? sum3 = 0;
              
            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]).GetValueOrDefault();
                    sum1 += mapFunc(source[i + 1]).GetValueOrDefault();
                    sum2 += mapFunc(source[i + 2]).GetValueOrDefault();
                    sum3 += mapFunc(source[i + 3]).GetValueOrDefault();
                
                }
                if (i == endIndex)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault());
                if (i == endIndex - 2)
                    return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault());
                return  (decimal) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]).GetValueOrDefault() + mapFunc(source[i+1]).GetValueOrDefault() + mapFunc(source[i+2]).GetValueOrDefault());
            }
        }
                
        #endregion
        
    
    }
}
