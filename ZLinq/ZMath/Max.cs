
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;
using ZLinq.Common;

// ReSharper disable CheckNamespace
// ReSharper disable RedundantCast
namespace ZLinq
{
    public static partial class ZEnumerable
    {

        
        
        #region sbyte             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static sbyte Max([NotNull] this sbyte[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            sbyte result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte Max([NotNull] this sbyte[] source, int startIndex, int endIndex)
        {
            sbyte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static sbyte Max<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            sbyte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte Max<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            sbyte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static sbyte Max([NotNull] this List<sbyte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            sbyte result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte Max([NotNull] this List<sbyte> source, int startIndex, int endIndex)
        {
            sbyte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static sbyte Max<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            sbyte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte Max<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            sbyte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static sbyte Max([NotNull] this IList<sbyte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            sbyte result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte Max([NotNull] this IList<sbyte> source, int startIndex, int endIndex)
        {
            sbyte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static sbyte Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            sbyte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            sbyte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region byte             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static byte Max([NotNull] this byte[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            byte result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte Max([NotNull] this byte[] source, int startIndex, int endIndex)
        {
            byte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                byte arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                byte arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                byte arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static byte Max<T>([NotNull] this T[] source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            byte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte Max<T>([NotNull] this T[] source, [NotNull] Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            byte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                byte arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                byte arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                byte arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static byte Max([NotNull] this List<byte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            byte result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte Max([NotNull] this List<byte> source, int startIndex, int endIndex)
        {
            byte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                byte arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                byte arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                byte arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static byte Max<T>([NotNull] this List<T> source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            byte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte Max<T>([NotNull] this List<T> source, [NotNull] Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            byte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                byte arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                byte arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                byte arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static byte Max([NotNull] this IList<byte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            byte result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte Max([NotNull] this IList<byte> source, int startIndex, int endIndex)
        {
            byte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                byte arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                byte arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                byte arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static byte Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            byte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            byte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                byte arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                byte arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                byte arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region short             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static short Max([NotNull] this short[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            short result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short Max([NotNull] this short[] source, int startIndex, int endIndex)
        {
            short max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                short arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                short arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                short arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static short Max<T>([NotNull] this T[] source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            short result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short Max<T>([NotNull] this T[] source, [NotNull] Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            short max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                short arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                short arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                short arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static short Max([NotNull] this List<short> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            short result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short Max([NotNull] this List<short> source, int startIndex, int endIndex)
        {
            short max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                short arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                short arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                short arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static short Max<T>([NotNull] this List<T> source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            short result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short Max<T>([NotNull] this List<T> source, [NotNull] Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            short max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                short arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                short arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                short arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static short Max([NotNull] this IList<short> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            short result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short Max([NotNull] this IList<short> source, int startIndex, int endIndex)
        {
            short max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                short arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                short arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                short arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static short Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            short result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            short max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                short arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                short arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                short arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region ushort             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ushort Max([NotNull] this ushort[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            ushort result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort Max([NotNull] this ushort[] source, int startIndex, int endIndex)
        {
            ushort max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                ushort arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                ushort arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                ushort arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ushort Max<T>([NotNull] this T[] source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            ushort result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort Max<T>([NotNull] this T[] source, [NotNull] Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            ushort max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                ushort arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                ushort arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                ushort arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ushort Max([NotNull] this List<ushort> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            ushort result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort Max([NotNull] this List<ushort> source, int startIndex, int endIndex)
        {
            ushort max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                ushort arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                ushort arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                ushort arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ushort Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            ushort result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            ushort max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                ushort arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                ushort arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                ushort arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ushort Max([NotNull] this IList<ushort> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            ushort result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort Max([NotNull] this IList<ushort> source, int startIndex, int endIndex)
        {
            ushort max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                ushort arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                ushort arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                ushort arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ushort Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            ushort result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            ushort max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                ushort arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                ushort arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                ushort arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region int             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static int Max([NotNull] this int[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            int result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int Max([NotNull] this int[] source, int startIndex, int endIndex)
        {
            int max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                int arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                int arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                int arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static int Max<T>([NotNull] this T[] source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            int result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int Max<T>([NotNull] this T[] source, [NotNull] Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                int arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                int arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                int arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static int Max([NotNull] this List<int> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            int result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int Max([NotNull] this List<int> source, int startIndex, int endIndex)
        {
            int max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                int arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                int arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                int arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static int Max<T>([NotNull] this List<T> source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            int result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int Max<T>([NotNull] this List<T> source, [NotNull] Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                int arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                int arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                int arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static int Max([NotNull] this IList<int> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            int result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int Max([NotNull] this IList<int> source, int startIndex, int endIndex)
        {
            int max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                int arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                int arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                int arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static int Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            int result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                int arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                int arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                int arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region uint             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static uint Max([NotNull] this uint[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            uint result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint Max([NotNull] this uint[] source, int startIndex, int endIndex)
        {
            uint max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                uint arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                uint arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                uint arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static uint Max<T>([NotNull] this T[] source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            uint result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint Max<T>([NotNull] this T[] source, [NotNull] Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            uint max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                uint arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                uint arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                uint arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static uint Max([NotNull] this List<uint> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            uint result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint Max([NotNull] this List<uint> source, int startIndex, int endIndex)
        {
            uint max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                uint arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                uint arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                uint arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static uint Max<T>([NotNull] this List<T> source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            uint result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint Max<T>([NotNull] this List<T> source, [NotNull] Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            uint max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                uint arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                uint arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                uint arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static uint Max([NotNull] this IList<uint> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            uint result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint Max([NotNull] this IList<uint> source, int startIndex, int endIndex)
        {
            uint max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                uint arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                uint arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                uint arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static uint Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            uint result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            uint max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                uint arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                uint arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                uint arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region long             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static long Max([NotNull] this long[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            long result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long Max([NotNull] this long[] source, int startIndex, int endIndex)
        {
            long max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                long arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                long arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                long arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static long Max<T>([NotNull] this T[] source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            long result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long Max<T>([NotNull] this T[] source, [NotNull] Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            long max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                long arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                long arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                long arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static long Max([NotNull] this List<long> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            long result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long Max([NotNull] this List<long> source, int startIndex, int endIndex)
        {
            long max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                long arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                long arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                long arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static long Max<T>([NotNull] this List<T> source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            long result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long Max<T>([NotNull] this List<T> source, [NotNull] Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            long max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                long arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                long arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                long arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static long Max([NotNull] this IList<long> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            long result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long Max([NotNull] this IList<long> source, int startIndex, int endIndex)
        {
            long max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                long arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                long arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                long arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static long Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            long result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            long max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                long arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                long arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                long arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region ulong             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ulong Max([NotNull] this ulong[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            ulong result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong Max([NotNull] this ulong[] source, int startIndex, int endIndex)
        {
            ulong max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                ulong arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                ulong arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                ulong arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ulong Max<T>([NotNull] this T[] source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            ulong result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong Max<T>([NotNull] this T[] source, [NotNull] Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            ulong max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                ulong arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                ulong arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                ulong arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ulong Max([NotNull] this List<ulong> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            ulong result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong Max([NotNull] this List<ulong> source, int startIndex, int endIndex)
        {
            ulong max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                ulong arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                ulong arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                ulong arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ulong Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            ulong result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            ulong max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                ulong arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                ulong arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                ulong arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ulong Max([NotNull] this IList<ulong> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            ulong result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong Max([NotNull] this IList<ulong> source, int startIndex, int endIndex)
        {
            ulong max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                ulong arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                ulong arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                ulong arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ulong Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            ulong result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            ulong max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                ulong arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                ulong arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                ulong arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region float             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static float Max([NotNull] this float[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            float result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float Max([NotNull] this float[] source, int startIndex, int endIndex)
        {
            float max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                float arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                float arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                float arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static float Max<T>([NotNull] this T[] source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            float result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float Max<T>([NotNull] this T[] source, [NotNull] Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            float max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                float arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                float arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                float arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static float Max([NotNull] this List<float> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            float result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float Max([NotNull] this List<float> source, int startIndex, int endIndex)
        {
            float max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                float arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                float arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                float arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static float Max<T>([NotNull] this List<T> source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            float result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float Max<T>([NotNull] this List<T> source, [NotNull] Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            float max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                float arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                float arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                float arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static float Max([NotNull] this IList<float> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            float result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float Max([NotNull] this IList<float> source, int startIndex, int endIndex)
        {
            float max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                float arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                float arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                float arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static float Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            float result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            float max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                float arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                float arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                float arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region double             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static double Max([NotNull] this double[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            double result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double Max([NotNull] this double[] source, int startIndex, int endIndex)
        {
            double max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                double arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                double arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                double arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static double Max<T>([NotNull] this T[] source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            double result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double Max<T>([NotNull] this T[] source, [NotNull] Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            double max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                double arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                double arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                double arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static double Max([NotNull] this List<double> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            double result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double Max([NotNull] this List<double> source, int startIndex, int endIndex)
        {
            double max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                double arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                double arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                double arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static double Max<T>([NotNull] this List<T> source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            double result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double Max<T>([NotNull] this List<T> source, [NotNull] Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            double max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                double arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                double arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                double arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static double Max([NotNull] this IList<double> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            double result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double Max([NotNull] this IList<double> source, int startIndex, int endIndex)
        {
            double max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                double arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                double arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                double arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static double Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            double result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            double max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                double arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                double arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                double arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region decimal             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static decimal Max([NotNull] this decimal[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            decimal result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal Max([NotNull] this decimal[] source, int startIndex, int endIndex)
        {
            decimal max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                decimal arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                decimal arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                decimal arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static decimal Max<T>([NotNull] this T[] source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            decimal result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal Max<T>([NotNull] this T[] source, [NotNull] Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            decimal max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                decimal arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                decimal arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                decimal arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static decimal Max([NotNull] this List<decimal> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            decimal result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal Max([NotNull] this List<decimal> source, int startIndex, int endIndex)
        {
            decimal max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                decimal arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                decimal arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                decimal arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static decimal Max<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            decimal result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal Max<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            decimal max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                decimal arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                decimal arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                decimal arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static decimal Max([NotNull] this IList<decimal> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Math.Max(source[0], source[1]);
                    case 3:
                        return Math.Max(source[0], Math.Max(source[1], source[2]));
                    case 4:
                        return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            decimal result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal Max([NotNull] this IList<decimal> source, int startIndex, int endIndex)
        {
            decimal max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = source[i + 0];
                if ( max0 < arg0)
                    max0 = arg0;
                decimal arg1 = source[i + 1];
                if ( max1 < arg1)
                    max1 = arg1;
                decimal arg2 = source[i + 2];
                if ( max2 < arg2)
                    max2 = arg2;
                decimal arg3 = source[i + 3];
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static decimal Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            decimal result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            decimal max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = mapFunc(source[i + 0]);
                if ( max0 < arg0)
                    max0 = arg0;
                decimal arg1 = mapFunc(source[i + 1]);
                if ( max1 < arg1)
                    max1 = arg1;
                decimal arg2 = mapFunc(source[i + 2]);
                if ( max2 < arg2)
                    max2 = arg2;
                decimal arg3 = mapFunc(source[i + 3]);
                if ( max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static sbyte? Max(sbyte? x, sbyte? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region sbyte?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static sbyte? Max([NotNull] this sbyte?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            sbyte? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte? Max([NotNull] this sbyte?[] source, int startIndex, int endIndex)
        {
            sbyte? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                sbyte? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                sbyte? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                sbyte? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (sbyte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static sbyte? Max<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            sbyte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte? Max<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
            sbyte? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                sbyte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                sbyte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                sbyte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (sbyte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static sbyte? Max([NotNull] this List<sbyte?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            sbyte? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte? Max([NotNull] this List<sbyte?> source, int startIndex, int endIndex)
        {
            sbyte? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                sbyte? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                sbyte? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                sbyte? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (sbyte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static sbyte? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            sbyte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
            sbyte? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                sbyte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                sbyte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                sbyte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (sbyte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static sbyte? Max([NotNull] this IList<sbyte?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            sbyte? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte? Max([NotNull] this IList<sbyte?> source, int startIndex, int endIndex)
        {
            sbyte? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                sbyte? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                sbyte? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                sbyte? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (sbyte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static sbyte? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            sbyte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static sbyte? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
            sbyte? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                sbyte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                sbyte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                sbyte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (sbyte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (sbyte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static byte? Max(byte? x, byte? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region byte?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static byte? Max([NotNull] this byte?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            byte? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte? Max([NotNull] this byte?[] source, int startIndex, int endIndex)
        {
            byte? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                byte? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                byte? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                byte? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (byte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static byte? Max<T>([NotNull] this T[] source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            byte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte? Max<T>([NotNull] this T[] source, [NotNull] Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
            byte? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                byte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                byte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                byte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (byte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static byte? Max([NotNull] this List<byte?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            byte? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte? Max([NotNull] this List<byte?> source, int startIndex, int endIndex)
        {
            byte? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                byte? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                byte? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                byte? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (byte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static byte? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            byte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
            byte? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                byte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                byte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                byte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (byte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static byte? Max([NotNull] this IList<byte?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            byte? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte? Max([NotNull] this IList<byte?> source, int startIndex, int endIndex)
        {
            byte? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                byte? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                byte? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                byte? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (byte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static byte? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            byte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static byte? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
            byte? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                byte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                byte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                byte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (byte?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (byte?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static short? Max(short? x, short? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region short?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static short? Max([NotNull] this short?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            short? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short? Max([NotNull] this short?[] source, int startIndex, int endIndex)
        {
            short? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                short? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                short? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                short? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (short?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static short? Max<T>([NotNull] this T[] source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            short? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short? Max<T>([NotNull] this T[] source, [NotNull] Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
            short? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                short? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                short? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                short? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (short?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static short? Max([NotNull] this List<short?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            short? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short? Max([NotNull] this List<short?> source, int startIndex, int endIndex)
        {
            short? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                short? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                short? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                short? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (short?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static short? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            short? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
            short? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                short? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                short? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                short? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (short?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static short? Max([NotNull] this IList<short?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            short? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short? Max([NotNull] this IList<short?> source, int startIndex, int endIndex)
        {
            short? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                short? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                short? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                short? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (short?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static short? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            short? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static short? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
            short? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                short? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                short? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                short? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (short?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (short?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static ushort? Max(ushort? x, ushort? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region ushort?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ushort? Max([NotNull] this ushort?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            ushort? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort? Max([NotNull] this ushort?[] source, int startIndex, int endIndex)
        {
            ushort? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ushort? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ushort? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ushort? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (ushort?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ushort? Max<T>([NotNull] this T[] source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            ushort? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort? Max<T>([NotNull] this T[] source, [NotNull] Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
            ushort? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ushort? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ushort? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ushort? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (ushort?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ushort? Max([NotNull] this List<ushort?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            ushort? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort? Max([NotNull] this List<ushort?> source, int startIndex, int endIndex)
        {
            ushort? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ushort? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ushort? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ushort? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (ushort?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ushort? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            ushort? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
            ushort? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ushort? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ushort? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ushort? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (ushort?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ushort? Max([NotNull] this IList<ushort?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            ushort? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort? Max([NotNull] this IList<ushort?> source, int startIndex, int endIndex)
        {
            ushort? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ushort? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ushort? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ushort? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (ushort?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ushort? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            ushort? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ushort? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
            ushort? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ushort? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ushort? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ushort? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (ushort?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ushort?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static int? Max(int? x, int? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region int?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static int? Max([NotNull] this int?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            int? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int? Max([NotNull] this int?[] source, int startIndex, int endIndex)
        {
            int? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                int? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                int? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                int? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (int?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static int? Max<T>([NotNull] this T[] source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            int? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int? Max<T>([NotNull] this T[] source, [NotNull] Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
            int? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                int? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                int? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                int? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (int?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static int? Max([NotNull] this List<int?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            int? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int? Max([NotNull] this List<int?> source, int startIndex, int endIndex)
        {
            int? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                int? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                int? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                int? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (int?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static int? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            int? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
            int? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                int? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                int? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                int? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (int?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static int? Max([NotNull] this IList<int?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            int? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int? Max([NotNull] this IList<int?> source, int startIndex, int endIndex)
        {
            int? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                int? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                int? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                int? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (int?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static int? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            int? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static int? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
            int? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                int? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                int? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                int? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (int?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (int?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static uint? Max(uint? x, uint? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region uint?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static uint? Max([NotNull] this uint?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            uint? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint? Max([NotNull] this uint?[] source, int startIndex, int endIndex)
        {
            uint? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                uint? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                uint? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                uint? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (uint?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static uint? Max<T>([NotNull] this T[] source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            uint? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint? Max<T>([NotNull] this T[] source, [NotNull] Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
            uint? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                uint? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                uint? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                uint? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (uint?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static uint? Max([NotNull] this List<uint?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            uint? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint? Max([NotNull] this List<uint?> source, int startIndex, int endIndex)
        {
            uint? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                uint? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                uint? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                uint? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (uint?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static uint? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            uint? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
            uint? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                uint? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                uint? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                uint? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (uint?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static uint? Max([NotNull] this IList<uint?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            uint? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint? Max([NotNull] this IList<uint?> source, int startIndex, int endIndex)
        {
            uint? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                uint? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                uint? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                uint? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (uint?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static uint? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            uint? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static uint? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
            uint? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                uint? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                uint? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                uint? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (uint?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (uint?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static long? Max(long? x, long? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region long?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static long? Max([NotNull] this long?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            long? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long? Max([NotNull] this long?[] source, int startIndex, int endIndex)
        {
            long? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                long? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                long? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                long? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (long?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static long? Max<T>([NotNull] this T[] source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            long? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long? Max<T>([NotNull] this T[] source, [NotNull] Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
            long? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                long? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                long? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                long? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (long?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static long? Max([NotNull] this List<long?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            long? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long? Max([NotNull] this List<long?> source, int startIndex, int endIndex)
        {
            long? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                long? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                long? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                long? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (long?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static long? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            long? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
            long? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                long? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                long? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                long? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (long?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static long? Max([NotNull] this IList<long?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            long? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long? Max([NotNull] this IList<long?> source, int startIndex, int endIndex)
        {
            long? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                long? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                long? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                long? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (long?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static long? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            long? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static long? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
            long? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                long? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                long? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                long? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (long?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (long?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static ulong? Max(ulong? x, ulong? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region ulong?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ulong? Max([NotNull] this ulong?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            ulong? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong? Max([NotNull] this ulong?[] source, int startIndex, int endIndex)
        {
            ulong? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ulong? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ulong? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ulong? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (ulong?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ulong? Max<T>([NotNull] this T[] source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            ulong? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong? Max<T>([NotNull] this T[] source, [NotNull] Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
            ulong? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ulong? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ulong? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ulong? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (ulong?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ulong? Max([NotNull] this List<ulong?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            ulong? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong? Max([NotNull] this List<ulong?> source, int startIndex, int endIndex)
        {
            ulong? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ulong? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ulong? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ulong? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (ulong?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ulong? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            ulong? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
            ulong? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ulong? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ulong? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ulong? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (ulong?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static ulong? Max([NotNull] this IList<ulong?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            ulong? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong? Max([NotNull] this IList<ulong?> source, int startIndex, int endIndex)
        {
            ulong? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ulong? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ulong? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ulong? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (ulong?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static ulong? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            ulong? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static ulong? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
            ulong? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                ulong? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                ulong? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                ulong? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (ulong?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ulong?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static float? Max(float? x, float? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region float?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static float? Max([NotNull] this float?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            float? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float? Max([NotNull] this float?[] source, int startIndex, int endIndex)
        {
            float? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                float? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                float? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                float? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (float?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static float? Max<T>([NotNull] this T[] source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            float? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float? Max<T>([NotNull] this T[] source, [NotNull] Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
            float? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                float? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                float? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                float? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (float?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static float? Max([NotNull] this List<float?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            float? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float? Max([NotNull] this List<float?> source, int startIndex, int endIndex)
        {
            float? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                float? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                float? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                float? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (float?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static float? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            float? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
            float? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                float? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                float? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                float? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (float?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static float? Max([NotNull] this IList<float?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            float? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float? Max([NotNull] this IList<float?> source, int startIndex, int endIndex)
        {
            float? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                float? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                float? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                float? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (float?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static float? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            float? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static float? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
            float? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                float? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                float? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                float? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (float?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (float?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static double? Max(double? x, double? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region double?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static double? Max([NotNull] this double?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            double? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double? Max([NotNull] this double?[] source, int startIndex, int endIndex)
        {
            double? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                double? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                double? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                double? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (double?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static double? Max<T>([NotNull] this T[] source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            double? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double? Max<T>([NotNull] this T[] source, [NotNull] Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
            double? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                double? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                double? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                double? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (double?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static double? Max([NotNull] this List<double?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            double? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double? Max([NotNull] this List<double?> source, int startIndex, int endIndex)
        {
            double? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                double? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                double? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                double? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (double?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static double? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            double? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
            double? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                double? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                double? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                double? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (double?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static double? Max([NotNull] this IList<double?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            double? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double? Max([NotNull] this IList<double?> source, int startIndex, int endIndex)
        {
            double? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                double? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                double? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                double? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (double?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static double? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            double? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static double? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
            double? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                double? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                double? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                double? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (double?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (double?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
                [Pure]
        private static decimal? Max(decimal? x, decimal? y)
        {
            bool hasValX = x.HasValue;
            bool hasValY = y.HasValue;
            if (hasValX && hasValY)
                return Math.Max(x.Value, y.Value);
            if (hasValX)
                return x.Value;
            return y.GetValueOrDefault();            
        }
        
        #region decimal?             
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static decimal? Max([NotNull] this decimal?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Length);
                }            
            }
            decimal? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal? Max([NotNull] this decimal?[] source, int startIndex, int endIndex)
        {
            decimal? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                decimal? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                decimal? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                decimal? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (decimal?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static decimal? Max<T>([NotNull] this T[] source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Length)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Length);
                }            
            }                
            decimal? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal? Max<T>([NotNull] this T[] source, [NotNull] Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
            decimal? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                decimal? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                decimal? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                decimal? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Length)
                return (decimal?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Length - 1)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static decimal? Max([NotNull] this List<decimal?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            decimal? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal? Max([NotNull] this List<decimal?> source, int startIndex, int endIndex)
        {
            decimal? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                decimal? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                decimal? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                decimal? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (decimal?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static decimal? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            decimal? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
            decimal? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                decimal? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                decimal? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                decimal? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (decimal?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
        /// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
        [Pure]
        public static decimal? Max([NotNull] this IList<decimal?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return source[0];
                    case 2:
                        return Max(source[0], source[1]);
                    case 3:
                        return Max(source[0], Max(source[1], source[2]));
                    case 4:
                        return Max(Max(source[0], source[1]), Max(source[2], source[3]));   
                    default:
                        return Max(source, 0, source.Count);
                }            
            }
            decimal? result = source.FirstOrDefault();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal? Max([NotNull] this IList<decimal?> source, int startIndex, int endIndex)
        {
            decimal? max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = source[i + 0];
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                decimal? arg1 = source[i + 1];
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                decimal? arg2 = source[i + 2];
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                decimal? arg3 = source[i + 3];
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (decimal?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], source[i + 1]));
            return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(source[i], Max(source[i + 1], source[i + 2])));
        } 

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
        [Pure]
        public static decimal? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull("source");
            mapFunc.IsNotNull("mapFunc");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                switch (source.Count)
                {
                    case 0:
                        return 0;
                    case 1:
                        return mapFunc(source[0]);
                    case 2:
                        return Max(mapFunc(source[0]), mapFunc(source[1]));
                    case 3:
                        return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));
                    case 4:
                        return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));   
                    default:
                        return Max(source, mapFunc, 0, source.Count);
                }            
            }                
            decimal? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

        [Pure]
        private static decimal? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
            decimal? max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && max0 < arg0)
                    max0 = arg0.Value;
                decimal? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && max1 < arg1)
                    max1 = arg1.Value;
                decimal? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && max2 < arg2)
                    max2 = arg2.Value;
                decimal? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && max3 < arg3)
                    max3 = arg3.Value;
                
            }
            if (i == source.Count)
                return (decimal?) Max(Max(max0, max1), Max(max2, max3));
            if (i == source.Count - 1)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (decimal?) Max(Max(Max(max0, max1), Max(max2, max3)), Max(mapFunc(source[i]), Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
    
    }
}
