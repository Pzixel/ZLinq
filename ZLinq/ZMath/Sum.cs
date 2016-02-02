
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading;
using System.Threading.Tasks;
using ZLinq.Extension;

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
        [Pure]
        public static sbyte Sum(this sbyte[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            sbyte result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static sbyte Sum(this sbyte[] source, int startIndex, int endIndex)
        {
            sbyte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (sbyte)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (sbyte)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (sbyte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (sbyte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static sbyte Sum<T>(this T[] source, Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (sbyte)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static sbyte Sum<T>(this T[] source, Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            sbyte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (sbyte) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (sbyte)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (sbyte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (sbyte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static sbyte Sum(this List<sbyte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static sbyte Sum(this List<sbyte> source, int startIndex, int endIndex)
        {
            sbyte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (sbyte)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (sbyte)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (sbyte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (sbyte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static sbyte Sum<T>(this List<T> source, Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (sbyte)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static sbyte Sum<T>(this List<T> source, Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            sbyte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (sbyte) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (sbyte)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (sbyte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (sbyte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static sbyte Sum(this IList<sbyte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static sbyte Sum(this IList<sbyte> source, int startIndex, int endIndex)
        {
            sbyte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (sbyte)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (sbyte)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (sbyte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (sbyte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static sbyte Sum<T>(this IList<T> source, Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (sbyte)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static sbyte Sum<T>(this IList<T> source, Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            sbyte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (sbyte) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (sbyte)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (sbyte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (sbyte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
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
        public static byte Sum(this byte[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            byte result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static byte Sum(this byte[] source, int startIndex, int endIndex)
        {
            byte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (byte)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (byte)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (byte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (byte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static byte Sum<T>(this T[] source, Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (byte)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static byte Sum<T>(this T[] source, Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            byte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (byte) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (byte)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (byte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (byte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static byte Sum(this List<byte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static byte Sum(this List<byte> source, int startIndex, int endIndex)
        {
            byte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (byte)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (byte)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (byte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (byte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static byte Sum<T>(this List<T> source, Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (byte)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static byte Sum<T>(this List<T> source, Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            byte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (byte) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (byte)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (byte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (byte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static byte Sum(this IList<byte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static byte Sum(this IList<byte> source, int startIndex, int endIndex)
        {
            byte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (byte)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (byte)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (byte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (byte)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static byte Sum<T>(this IList<T> source, Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (byte)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static byte Sum<T>(this IList<T> source, Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            byte sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (byte) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (byte)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (byte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (byte)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
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
        public static short Sum(this short[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            short result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static short Sum(this short[] source, int startIndex, int endIndex)
        {
            short sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (short)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (short)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (short)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (short)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static short Sum<T>(this T[] source, Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (short)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static short Sum<T>(this T[] source, Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            short sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (short) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (short)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (short)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (short)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static short Sum(this List<short> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            short result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static short Sum(this List<short> source, int startIndex, int endIndex)
        {
            short sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (short)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (short)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (short)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (short)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static short Sum<T>(this List<T> source, Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (short)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static short Sum<T>(this List<T> source, Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            short sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (short) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (short)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (short)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (short)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static short Sum(this IList<short> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            short result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static short Sum(this IList<short> source, int startIndex, int endIndex)
        {
            short sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (short)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (short)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (short)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (short)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static short Sum<T>(this IList<T> source, Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (short)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static short Sum<T>(this IList<T> source, Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            short sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (short) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (short)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (short)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (short)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
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
        public static ushort Sum(this ushort[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            ushort result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static ushort Sum(this ushort[] source, int startIndex, int endIndex)
        {
            ushort sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (ushort)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (ushort)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (ushort)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (ushort)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static ushort Sum<T>(this T[] source, Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (ushort)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static ushort Sum<T>(this T[] source, Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            ushort sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (ushort) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (ushort)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (ushort)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (ushort)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static ushort Sum(this List<ushort> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static ushort Sum(this List<ushort> source, int startIndex, int endIndex)
        {
            ushort sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (ushort)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (ushort)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (ushort)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (ushort)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static ushort Sum<T>(this List<T> source, Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ushort)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static ushort Sum<T>(this List<T> source, Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            ushort sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (ushort) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (ushort)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (ushort)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (ushort)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static ushort Sum(this IList<ushort> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static ushort Sum(this IList<ushort> source, int startIndex, int endIndex)
        {
            ushort sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return (ushort)((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return (ushort)((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return (ushort)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return (ushort)((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static ushort Sum<T>(this IList<T> source, Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ushort)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static ushort Sum<T>(this IList<T> source, Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            ushort sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return  (ushort) ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  (ushort)((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  (ushort)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  (ushort)((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
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
        public static int Sum(this int[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            int result = 0;
                
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        Interlocked.Add(ref result, x);       
                    });
              
            return result;
        }

        [Pure]
        private static int Sum(this int[] source, int startIndex, int endIndex)
        {
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static int Sum<T>(this T[] source, Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (int)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static int Sum<T>(this T[] source, Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static int Sum(this List<int> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            int result = 0;
                
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        Interlocked.Add(ref result, x);       
                    });
              
            return result;
        }

        [Pure]
        private static int Sum(this List<int> source, int startIndex, int endIndex)
        {
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static int Sum<T>(this List<T> source, Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (int)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static int Sum<T>(this List<T> source, Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static int Sum(this IList<int> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            int result = 0;
                
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        Interlocked.Add(ref result, x);       
                    });
              
            return result;
        }

        [Pure]
        private static int Sum(this IList<int> source, int startIndex, int endIndex)
        {
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static int Sum<T>(this IList<T> source, Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (int)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static int Sum<T>(this IList<T> source, Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
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
        public static uint Sum(this uint[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            uint result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static uint Sum(this uint[] source, int startIndex, int endIndex)
        {
            uint sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static uint Sum<T>(this T[] source, Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (uint)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static uint Sum<T>(this T[] source, Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            uint sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static uint Sum(this List<uint> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static uint Sum(this List<uint> source, int startIndex, int endIndex)
        {
            uint sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static uint Sum<T>(this List<T> source, Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (uint)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static uint Sum<T>(this List<T> source, Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            uint sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static uint Sum(this IList<uint> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static uint Sum(this IList<uint> source, int startIndex, int endIndex)
        {
            uint sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static uint Sum<T>(this IList<T> source, Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (uint)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static uint Sum<T>(this IList<T> source, Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            uint sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
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
        public static long Sum(this long[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            long result = 0;
                
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        Interlocked.Add(ref result, x);       
                    });
              
            return result;
        }

        [Pure]
        private static long Sum(this long[] source, int startIndex, int endIndex)
        {
            long sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static long Sum<T>(this T[] source, Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (long)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static long Sum<T>(this T[] source, Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            long sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static long Sum(this List<long> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            long result = 0;
                
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        Interlocked.Add(ref result, x);       
                    });
              
            return result;
        }

        [Pure]
        private static long Sum(this List<long> source, int startIndex, int endIndex)
        {
            long sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static long Sum<T>(this List<T> source, Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (long)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static long Sum<T>(this List<T> source, Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            long sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static long Sum(this IList<long> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            long result = 0;
                
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        Interlocked.Add(ref result, x);       
                    });
              
            return result;
        }

        [Pure]
        private static long Sum(this IList<long> source, int startIndex, int endIndex)
        {
            long sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static long Sum<T>(this IList<T> source, Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (long)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static long Sum<T>(this IList<T> source, Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            long sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
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
        public static float Sum(this float[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            float result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static float Sum(this float[] source, int startIndex, int endIndex)
        {
            float sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static float Sum<T>(this T[] source, Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (float)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static float Sum<T>(this T[] source, Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            float sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static float Sum(this List<float> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            float result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static float Sum(this List<float> source, int startIndex, int endIndex)
        {
            float sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static float Sum<T>(this List<T> source, Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (float)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static float Sum<T>(this List<T> source, Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            float sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static float Sum(this IList<float> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            float result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static float Sum(this IList<float> source, int startIndex, int endIndex)
        {
            float sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static float Sum<T>(this IList<T> source, Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (float)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static float Sum<T>(this IList<T> source, Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            float sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
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
        public static double Sum(this double[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            double result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static double Sum(this double[] source, int startIndex, int endIndex)
        {
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Sum<T>(this T[] source, Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (double)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static double Sum<T>(this T[] source, Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Sum(this List<double> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            double result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static double Sum(this List<double> source, int startIndex, int endIndex)
        {
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Sum<T>(this List<T> source, Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (double)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static double Sum<T>(this List<T> source, Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Sum(this IList<double> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            double result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static double Sum(this IList<double> source, int startIndex, int endIndex)
        {
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static double Sum<T>(this IList<T> source, Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (double)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static double Sum<T>(this IList<T> source, Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
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
        public static decimal Sum(this decimal[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            decimal result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static decimal Sum(this decimal[] source, int startIndex, int endIndex)
        {
            decimal sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static decimal Sum<T>(this T[] source, Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (decimal)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static decimal Sum<T>(this T[] source, Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            decimal sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static decimal Sum(this List<decimal> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static decimal Sum(this List<decimal> source, int startIndex, int endIndex)
        {
            decimal sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static decimal Sum<T>(this List<T> source, Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (decimal)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static decimal Sum<T>(this List<T> source, Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            decimal sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static decimal Sum(this IList<decimal> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static decimal Sum(this IList<decimal> source, int startIndex, int endIndex)
        {
            decimal sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static decimal Sum<T>(this IList<T> source, Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (decimal)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static decimal Sum<T>(this IList<T> source, Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            decimal sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
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
        public static ulong Sum(this ulong[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Length);
            ulong result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static ulong Sum(this ulong[] source, int startIndex, int endIndex)
        {
            ulong sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static ulong Sum<T>(this T[] source, Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Length);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (ulong)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static ulong Sum<T>(this T[] source, Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            ulong sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static ulong Sum(this List<ulong> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static ulong Sum(this List<ulong> source, int startIndex, int endIndex)
        {
            ulong sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static ulong Sum<T>(this List<T> source, Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ulong)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static ulong Sum<T>(this List<T> source, Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            ulong sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
            
        /// <summary>
        /// Perform checked summing of source collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static ulong Sum(this IList<ulong> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();     
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                        range => {
                        var x = Sum(source, range.Item1, range.Item2);
                        lock (syncRoot)
                            result += x;                        
                              
                    });
              
            return result;
        }

        [Pure]
        private static ulong Sum(this IList<ulong> source, int startIndex, int endIndex)
        {
            ulong sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += source[i];
                    sum2 += source[i + 1];
                    sum3 += source[i + 2];
                    sum4 += source[i + 3];
                }

                if (i == endIndex)
                    return ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return ((sum1 + sum2) + (sum3 + sum4) + source[i]);
                if (i == endIndex - 2)
                    return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1]));
                return ((sum1 + sum2) + (sum3 + sum4) + (source[i] + source[i + 1] + source[i + 2]));
            }
        }

        /// <summary>
        /// Perform checked summing of source collection mapping
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform summing</param>
        /// <returns>Sum of all elements</returns>
        [Pure]
        public static ulong Sum<T>(this IList<T> source, Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Sum(source, mapFunc, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ulong)0,
                (range, state, sum) => Sum(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        result += x;
                });

            return result;
        }

        [Pure]
        private static ulong Sum<T>(this IList<T> source, Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            ulong sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            checked
            {
                int i;
                for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
                {
                    sum1 += mapFunc(source[i]);
                    sum2 += mapFunc(source[i + 1]);
                    sum3 += mapFunc(source[i + 2]);
                    sum4 += mapFunc(source[i + 3]);
                }
                if (i == endIndex)
                    return   ((sum1 + sum2) + (sum3 + sum4));
                if (i == endIndex - 1)
                    return  ((sum1 + sum2) + (sum3 + sum4) + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1])));
                return  ((sum1 + sum2) + (sum3 + sum4) + (mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2])));
            }
        }
        
        #endregion
        
    }
}
