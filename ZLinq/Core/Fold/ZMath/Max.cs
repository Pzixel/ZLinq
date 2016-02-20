
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static sbyte Max([NotNull] this sbyte[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            sbyte result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte Max([NotNull] this sbyte[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            sbyte max0 = source[startIndex + 0];
            sbyte max1 = source[startIndex + 1];
            sbyte max2 = source[startIndex + 2];
            sbyte max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static sbyte Max<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            sbyte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte Max<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            sbyte max0 = mapFunc(source[startIndex + 0]);
            sbyte max1 = mapFunc(source[startIndex + 1]);
            sbyte max2 = mapFunc(source[startIndex + 2]);
            sbyte max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static sbyte Max([NotNull] this List<sbyte> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            sbyte result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte Max([NotNull] this List<sbyte> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            sbyte max0 = source[startIndex + 0];
            sbyte max1 = source[startIndex + 1];
            sbyte max2 = source[startIndex + 2];
            sbyte max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static sbyte Max<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            sbyte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte Max<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            sbyte max0 = mapFunc(source[startIndex + 0]);
            sbyte max1 = mapFunc(source[startIndex + 1]);
            sbyte max2 = mapFunc(source[startIndex + 2]);
            sbyte max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static sbyte Max([NotNull] this IList<sbyte> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            sbyte result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte Max([NotNull] this IList<sbyte> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            sbyte max0 = source[startIndex + 0];
            sbyte max1 = source[startIndex + 1];
            sbyte max2 = source[startIndex + 2];
            sbyte max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static sbyte Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            sbyte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            sbyte max0 = mapFunc(source[startIndex + 0]);
            sbyte max1 = mapFunc(source[startIndex + 1]);
            sbyte max2 = mapFunc(source[startIndex + 2]);
            sbyte max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                sbyte arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                sbyte arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                sbyte arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static byte Max([NotNull] this byte[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            byte result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte Max([NotNull] this byte[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            byte max0 = source[startIndex + 0];
            byte max1 = source[startIndex + 1];
            byte max2 = source[startIndex + 2];
            byte max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                byte arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                byte arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                byte arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static byte Max<T>([NotNull] this T[] source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            byte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte Max<T>([NotNull] this T[] source, [NotNull] Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            byte max0 = mapFunc(source[startIndex + 0]);
            byte max1 = mapFunc(source[startIndex + 1]);
            byte max2 = mapFunc(source[startIndex + 2]);
            byte max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                byte arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                byte arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                byte arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static byte Max([NotNull] this List<byte> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            byte result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte Max([NotNull] this List<byte> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            byte max0 = source[startIndex + 0];
            byte max1 = source[startIndex + 1];
            byte max2 = source[startIndex + 2];
            byte max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                byte arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                byte arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                byte arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static byte Max<T>([NotNull] this List<T> source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            byte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte Max<T>([NotNull] this List<T> source, [NotNull] Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            byte max0 = mapFunc(source[startIndex + 0]);
            byte max1 = mapFunc(source[startIndex + 1]);
            byte max2 = mapFunc(source[startIndex + 2]);
            byte max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                byte arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                byte arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                byte arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static byte Max([NotNull] this IList<byte> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            byte result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte Max([NotNull] this IList<byte> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            byte max0 = source[startIndex + 0];
            byte max1 = source[startIndex + 1];
            byte max2 = source[startIndex + 2];
            byte max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                byte arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                byte arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                byte arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static byte Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            byte result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            byte max0 = mapFunc(source[startIndex + 0]);
            byte max1 = mapFunc(source[startIndex + 1]);
            byte max2 = mapFunc(source[startIndex + 2]);
            byte max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                byte arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                byte arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                byte arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static short Max([NotNull] this short[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            short result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short Max([NotNull] this short[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            short max0 = source[startIndex + 0];
            short max1 = source[startIndex + 1];
            short max2 = source[startIndex + 2];
            short max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                short arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                short arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                short arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static short Max<T>([NotNull] this T[] source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            short result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short Max<T>([NotNull] this T[] source, [NotNull] Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            short max0 = mapFunc(source[startIndex + 0]);
            short max1 = mapFunc(source[startIndex + 1]);
            short max2 = mapFunc(source[startIndex + 2]);
            short max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                short arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                short arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                short arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static short Max([NotNull] this List<short> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            short result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short Max([NotNull] this List<short> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            short max0 = source[startIndex + 0];
            short max1 = source[startIndex + 1];
            short max2 = source[startIndex + 2];
            short max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                short arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                short arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                short arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static short Max<T>([NotNull] this List<T> source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            short result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short Max<T>([NotNull] this List<T> source, [NotNull] Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            short max0 = mapFunc(source[startIndex + 0]);
            short max1 = mapFunc(source[startIndex + 1]);
            short max2 = mapFunc(source[startIndex + 2]);
            short max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                short arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                short arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                short arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static short Max([NotNull] this IList<short> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            short result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short Max([NotNull] this IList<short> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            short max0 = source[startIndex + 0];
            short max1 = source[startIndex + 1];
            short max2 = source[startIndex + 2];
            short max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                short arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                short arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                short arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static short Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, short> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            short result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, short> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            short max0 = mapFunc(source[startIndex + 0]);
            short max1 = mapFunc(source[startIndex + 1]);
            short max2 = mapFunc(source[startIndex + 2]);
            short max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                short arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                short arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                short arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ushort Max([NotNull] this ushort[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            ushort result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort Max([NotNull] this ushort[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            ushort max0 = source[startIndex + 0];
            ushort max1 = source[startIndex + 1];
            ushort max2 = source[startIndex + 2];
            ushort max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                ushort arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                ushort arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                ushort arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ushort Max<T>([NotNull] this T[] source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            ushort result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort Max<T>([NotNull] this T[] source, [NotNull] Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ushort max0 = mapFunc(source[startIndex + 0]);
            ushort max1 = mapFunc(source[startIndex + 1]);
            ushort max2 = mapFunc(source[startIndex + 2]);
            ushort max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                ushort arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                ushort arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                ushort arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ushort Max([NotNull] this List<ushort> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            ushort result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort Max([NotNull] this List<ushort> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            ushort max0 = source[startIndex + 0];
            ushort max1 = source[startIndex + 1];
            ushort max2 = source[startIndex + 2];
            ushort max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                ushort arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                ushort arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                ushort arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ushort Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            ushort result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ushort max0 = mapFunc(source[startIndex + 0]);
            ushort max1 = mapFunc(source[startIndex + 1]);
            ushort max2 = mapFunc(source[startIndex + 2]);
            ushort max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                ushort arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                ushort arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                ushort arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ushort Max([NotNull] this IList<ushort> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            ushort result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort Max([NotNull] this IList<ushort> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            ushort max0 = source[startIndex + 0];
            ushort max1 = source[startIndex + 1];
            ushort max2 = source[startIndex + 2];
            ushort max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                ushort arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                ushort arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                ushort arg3 = source[i + 3];
                if (max3 < arg3)
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ushort Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            ushort result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ushort max0 = mapFunc(source[startIndex + 0]);
            ushort max1 = mapFunc(source[startIndex + 1]);
            ushort max2 = mapFunc(source[startIndex + 2]);
            ushort max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                ushort arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                ushort arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                ushort arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static int Max([NotNull] this int[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            int result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int Max([NotNull] this int[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            int max0 = source[startIndex + 0];
            int max1 = source[startIndex + 1];
            int max2 = source[startIndex + 2];
            int max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                int arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                int arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                int arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (int) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static int Max<T>([NotNull] this T[] source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            int result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int Max<T>([NotNull] this T[] source, [NotNull] Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            int max0 = mapFunc(source[startIndex + 0]);
            int max1 = mapFunc(source[startIndex + 1]);
            int max2 = mapFunc(source[startIndex + 2]);
            int max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                int arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                int arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                int arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (int) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static int Max([NotNull] this List<int> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            int result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int Max([NotNull] this List<int> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            int max0 = source[startIndex + 0];
            int max1 = source[startIndex + 1];
            int max2 = source[startIndex + 2];
            int max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                int arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                int arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                int arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (int) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static int Max<T>([NotNull] this List<T> source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            int result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int Max<T>([NotNull] this List<T> source, [NotNull] Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            int max0 = mapFunc(source[startIndex + 0]);
            int max1 = mapFunc(source[startIndex + 1]);
            int max2 = mapFunc(source[startIndex + 2]);
            int max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                int arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                int arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                int arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (int) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static int Max([NotNull] this IList<int> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            int result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int Max([NotNull] this IList<int> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            int max0 = source[startIndex + 0];
            int max1 = source[startIndex + 1];
            int max2 = source[startIndex + 2];
            int max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                int arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                int arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                int arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (int) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static int Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, int> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            int result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            int max0 = mapFunc(source[startIndex + 0]);
            int max1 = mapFunc(source[startIndex + 1]);
            int max2 = mapFunc(source[startIndex + 2]);
            int max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                int arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                int arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                int arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (int) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (int) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region uint             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static uint Max([NotNull] this uint[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            uint result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint Max([NotNull] this uint[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            uint max0 = source[startIndex + 0];
            uint max1 = source[startIndex + 1];
            uint max2 = source[startIndex + 2];
            uint max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                uint arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                uint arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                uint arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (uint) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static uint Max<T>([NotNull] this T[] source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            uint result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint Max<T>([NotNull] this T[] source, [NotNull] Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            uint max0 = mapFunc(source[startIndex + 0]);
            uint max1 = mapFunc(source[startIndex + 1]);
            uint max2 = mapFunc(source[startIndex + 2]);
            uint max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                uint arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                uint arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                uint arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (uint) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static uint Max([NotNull] this List<uint> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            uint result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint Max([NotNull] this List<uint> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            uint max0 = source[startIndex + 0];
            uint max1 = source[startIndex + 1];
            uint max2 = source[startIndex + 2];
            uint max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                uint arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                uint arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                uint arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (uint) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static uint Max<T>([NotNull] this List<T> source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            uint result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint Max<T>([NotNull] this List<T> source, [NotNull] Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            uint max0 = mapFunc(source[startIndex + 0]);
            uint max1 = mapFunc(source[startIndex + 1]);
            uint max2 = mapFunc(source[startIndex + 2]);
            uint max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                uint arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                uint arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                uint arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (uint) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static uint Max([NotNull] this IList<uint> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            uint result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint Max([NotNull] this IList<uint> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            uint max0 = source[startIndex + 0];
            uint max1 = source[startIndex + 1];
            uint max2 = source[startIndex + 2];
            uint max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                uint arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                uint arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                uint arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (uint) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static uint Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            uint result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            uint max0 = mapFunc(source[startIndex + 0]);
            uint max1 = mapFunc(source[startIndex + 1]);
            uint max2 = mapFunc(source[startIndex + 2]);
            uint max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                uint arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                uint arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                uint arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (uint) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (uint) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region long             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static long Max([NotNull] this long[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            long result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long Max([NotNull] this long[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            long max0 = source[startIndex + 0];
            long max1 = source[startIndex + 1];
            long max2 = source[startIndex + 2];
            long max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                long arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                long arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                long arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (long) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static long Max<T>([NotNull] this T[] source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            long result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long Max<T>([NotNull] this T[] source, [NotNull] Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            long max0 = mapFunc(source[startIndex + 0]);
            long max1 = mapFunc(source[startIndex + 1]);
            long max2 = mapFunc(source[startIndex + 2]);
            long max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                long arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                long arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                long arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (long) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static long Max([NotNull] this List<long> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            long result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long Max([NotNull] this List<long> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            long max0 = source[startIndex + 0];
            long max1 = source[startIndex + 1];
            long max2 = source[startIndex + 2];
            long max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                long arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                long arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                long arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (long) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static long Max<T>([NotNull] this List<T> source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            long result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long Max<T>([NotNull] this List<T> source, [NotNull] Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            long max0 = mapFunc(source[startIndex + 0]);
            long max1 = mapFunc(source[startIndex + 1]);
            long max2 = mapFunc(source[startIndex + 2]);
            long max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                long arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                long arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                long arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (long) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static long Max([NotNull] this IList<long> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            long result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long Max([NotNull] this IList<long> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            long max0 = source[startIndex + 0];
            long max1 = source[startIndex + 1];
            long max2 = source[startIndex + 2];
            long max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                long arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                long arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                long arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (long) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static long Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, long> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            long result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, long> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            long max0 = mapFunc(source[startIndex + 0]);
            long max1 = mapFunc(source[startIndex + 1]);
            long max2 = mapFunc(source[startIndex + 2]);
            long max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                long arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                long arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                long arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (long) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (long) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region ulong             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ulong Max([NotNull] this ulong[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            ulong result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong Max([NotNull] this ulong[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            ulong max0 = source[startIndex + 0];
            ulong max1 = source[startIndex + 1];
            ulong max2 = source[startIndex + 2];
            ulong max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                ulong arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                ulong arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                ulong arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (ulong) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ulong Max<T>([NotNull] this T[] source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            ulong result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong Max<T>([NotNull] this T[] source, [NotNull] Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ulong max0 = mapFunc(source[startIndex + 0]);
            ulong max1 = mapFunc(source[startIndex + 1]);
            ulong max2 = mapFunc(source[startIndex + 2]);
            ulong max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                ulong arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                ulong arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                ulong arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (ulong) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ulong Max([NotNull] this List<ulong> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            ulong result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong Max([NotNull] this List<ulong> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            ulong max0 = source[startIndex + 0];
            ulong max1 = source[startIndex + 1];
            ulong max2 = source[startIndex + 2];
            ulong max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                ulong arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                ulong arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                ulong arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (ulong) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ulong Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            ulong result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ulong max0 = mapFunc(source[startIndex + 0]);
            ulong max1 = mapFunc(source[startIndex + 1]);
            ulong max2 = mapFunc(source[startIndex + 2]);
            ulong max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                ulong arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                ulong arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                ulong arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (ulong) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ulong Max([NotNull] this IList<ulong> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            ulong result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong Max([NotNull] this IList<ulong> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            ulong max0 = source[startIndex + 0];
            ulong max1 = source[startIndex + 1];
            ulong max2 = source[startIndex + 2];
            ulong max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                ulong arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                ulong arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                ulong arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (ulong) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ulong Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            ulong result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ulong max0 = mapFunc(source[startIndex + 0]);
            ulong max1 = mapFunc(source[startIndex + 1]);
            ulong max2 = mapFunc(source[startIndex + 2]);
            ulong max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                ulong arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                ulong arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                ulong arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (ulong) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (ulong) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region float             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static float Max([NotNull] this float[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            float result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float Max([NotNull] this float[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            float max0 = source[startIndex + 0];
            float max1 = source[startIndex + 1];
            float max2 = source[startIndex + 2];
            float max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                float arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                float arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                float arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (float) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static float Max<T>([NotNull] this T[] source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            float result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float Max<T>([NotNull] this T[] source, [NotNull] Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            float max0 = mapFunc(source[startIndex + 0]);
            float max1 = mapFunc(source[startIndex + 1]);
            float max2 = mapFunc(source[startIndex + 2]);
            float max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                float arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                float arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                float arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (float) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static float Max([NotNull] this List<float> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            float result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float Max([NotNull] this List<float> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            float max0 = source[startIndex + 0];
            float max1 = source[startIndex + 1];
            float max2 = source[startIndex + 2];
            float max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                float arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                float arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                float arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (float) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static float Max<T>([NotNull] this List<T> source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            float result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float Max<T>([NotNull] this List<T> source, [NotNull] Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            float max0 = mapFunc(source[startIndex + 0]);
            float max1 = mapFunc(source[startIndex + 1]);
            float max2 = mapFunc(source[startIndex + 2]);
            float max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                float arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                float arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                float arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (float) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static float Max([NotNull] this IList<float> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            float result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float Max([NotNull] this IList<float> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            float max0 = source[startIndex + 0];
            float max1 = source[startIndex + 1];
            float max2 = source[startIndex + 2];
            float max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                float arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                float arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                float arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (float) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static float Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, float> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            float result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, float> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            float max0 = mapFunc(source[startIndex + 0]);
            float max1 = mapFunc(source[startIndex + 1]);
            float max2 = mapFunc(source[startIndex + 2]);
            float max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                float arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                float arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                float arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (float) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (float) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region double             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static double Max([NotNull] this double[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            double result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double Max([NotNull] this double[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            double max0 = source[startIndex + 0];
            double max1 = source[startIndex + 1];
            double max2 = source[startIndex + 2];
            double max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                double arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                double arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                double arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (double) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static double Max<T>([NotNull] this T[] source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            double result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double Max<T>([NotNull] this T[] source, [NotNull] Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            double max0 = mapFunc(source[startIndex + 0]);
            double max1 = mapFunc(source[startIndex + 1]);
            double max2 = mapFunc(source[startIndex + 2]);
            double max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                double arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                double arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                double arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (double) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static double Max([NotNull] this List<double> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            double result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double Max([NotNull] this List<double> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            double max0 = source[startIndex + 0];
            double max1 = source[startIndex + 1];
            double max2 = source[startIndex + 2];
            double max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                double arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                double arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                double arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (double) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static double Max<T>([NotNull] this List<T> source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            double result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double Max<T>([NotNull] this List<T> source, [NotNull] Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            double max0 = mapFunc(source[startIndex + 0]);
            double max1 = mapFunc(source[startIndex + 1]);
            double max2 = mapFunc(source[startIndex + 2]);
            double max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                double arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                double arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                double arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (double) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static double Max([NotNull] this IList<double> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            double result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double Max([NotNull] this IList<double> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            double max0 = source[startIndex + 0];
            double max1 = source[startIndex + 1];
            double max2 = source[startIndex + 2];
            double max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                double arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                double arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                double arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (double) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static double Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, double> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            double result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, double> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            double max0 = mapFunc(source[startIndex + 0]);
            double max1 = mapFunc(source[startIndex + 1]);
            double max2 = mapFunc(source[startIndex + 2]);
            double max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                double arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                double arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                double arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (double) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (double) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        #region decimal             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static decimal Max([NotNull] this decimal[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            decimal result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal Max([NotNull] this decimal[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            decimal max0 = source[startIndex + 0];
            decimal max1 = source[startIndex + 1];
            decimal max2 = source[startIndex + 2];
            decimal max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                decimal arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                decimal arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                decimal arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (decimal) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Length - 2)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static decimal Max<T>([NotNull] this T[] source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            decimal result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal Max<T>([NotNull] this T[] source, [NotNull] Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            decimal max0 = mapFunc(source[startIndex + 0]);
            decimal max1 = mapFunc(source[startIndex + 1]);
            decimal max2 = mapFunc(source[startIndex + 2]);
            decimal max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                decimal arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                decimal arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                decimal arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Length)
                return (decimal) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Length - 2)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static decimal Max([NotNull] this List<decimal> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            decimal result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal Max([NotNull] this List<decimal> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            decimal max0 = source[startIndex + 0];
            decimal max1 = source[startIndex + 1];
            decimal max2 = source[startIndex + 2];
            decimal max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                decimal arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                decimal arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                decimal arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (decimal) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static decimal Max<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            decimal result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal Max<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            decimal max0 = mapFunc(source[startIndex + 0]);
            decimal max1 = mapFunc(source[startIndex + 1]);
            decimal max2 = mapFunc(source[startIndex + 2]);
            decimal max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                decimal arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                decimal arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                decimal arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (decimal) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static decimal Max([NotNull] this IList<decimal> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            decimal result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal Max([NotNull] this IList<decimal> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Math.Max(source[0], source[1]);  
                case 3:
                    return Math.Max(source[0], Math.Max(source[1], source[2]));  
                case 4:
                    return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));    
                }
            }
            decimal max0 = source[startIndex + 0];
            decimal max1 = source[startIndex + 1];
            decimal max2 = source[startIndex + 2];
            decimal max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = source[i + 0];
                if (max0 < arg0)
                    max0 = arg0;
                decimal arg1 = source[i + 1];
                if (max1 < arg1)
                    max1 = arg1;
                decimal arg2 = source[i + 2];
                if (max2 < arg2)
                    max2 = arg2;
                decimal arg3 = source[i + 3];
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (decimal) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i]);
            if (i == source.Count - 2)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], source[i + 1]));
            return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i], Math.Max(source[i + 1], source[i + 2])));
        } 
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
		/// <param name="mapFunc">Function that maps each element of source to perform search</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static decimal Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            decimal result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (result < x)
                    {
                        lock (syncRoot)
                        {
                            if (result < x)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Math.Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            decimal max0 = mapFunc(source[startIndex + 0]);
            decimal max1 = mapFunc(source[startIndex + 1]);
            decimal max2 = mapFunc(source[startIndex + 2]);
            decimal max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal arg0 = mapFunc(source[i + 0]);
                if (max0 < arg0)
                    max0 = arg0;
                decimal arg1 = mapFunc(source[i + 1]);
                if (max1 < arg1)
                    max1 = arg1;
                decimal arg2 = mapFunc(source[i + 2]);
                if (max2 < arg2)
                    max2 = arg2;
                decimal arg3 = mapFunc(source[i + 3]);
                if (max3 < arg3)
                    max3 = arg3;
                
            }
            if (i == source.Count)
                return (decimal) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]));
            if (i == source.Count - 2)
                return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), mapFunc(source[i + 1])));
            return (decimal) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]), Math.Max(mapFunc(source[i + 1]), mapFunc(source[i + 2]))));
        } 
                
    #endregion
        
        
        [Pure]
        private static sbyte? Max(sbyte? x, sbyte? y)
        {
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region sbyte?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static sbyte? Max([NotNull] this sbyte?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            sbyte? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte? Max([NotNull] this sbyte?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            sbyte? max0 = source[startIndex + 0];
            sbyte? max1 = source[startIndex + 1];
            sbyte? max2 = source[startIndex + 2];
            sbyte? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                sbyte? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                sbyte? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                sbyte? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static sbyte? Max<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            sbyte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte? Max<T>([NotNull] this T[] source, [NotNull] Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            sbyte? max0 = mapFunc(source[startIndex + 0]);
            sbyte? max1 = mapFunc(source[startIndex + 1]);
            sbyte? max2 = mapFunc(source[startIndex + 2]);
            sbyte? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                sbyte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                sbyte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                sbyte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static sbyte? Max([NotNull] this List<sbyte?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            sbyte? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte? Max([NotNull] this List<sbyte?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            sbyte? max0 = source[startIndex + 0];
            sbyte? max1 = source[startIndex + 1];
            sbyte? max2 = source[startIndex + 2];
            sbyte? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                sbyte? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                sbyte? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                sbyte? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static sbyte? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            sbyte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            sbyte? max0 = mapFunc(source[startIndex + 0]);
            sbyte? max1 = mapFunc(source[startIndex + 1]);
            sbyte? max2 = mapFunc(source[startIndex + 2]);
            sbyte? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                sbyte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                sbyte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                sbyte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static sbyte? Max([NotNull] this IList<sbyte?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            sbyte? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte? Max([NotNull] this IList<sbyte?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            sbyte? max0 = source[startIndex + 0];
            sbyte? max1 = source[startIndex + 1];
            sbyte? max2 = source[startIndex + 2];
            sbyte? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                sbyte? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                sbyte? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                sbyte? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static sbyte? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            sbyte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static sbyte? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            sbyte? max0 = mapFunc(source[startIndex + 0]);
            sbyte? max1 = mapFunc(source[startIndex + 1]);
            sbyte? max2 = mapFunc(source[startIndex + 2]);
            sbyte? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                sbyte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                sbyte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                sbyte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                sbyte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region byte?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static byte? Max([NotNull] this byte?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            byte? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte? Max([NotNull] this byte?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            byte? max0 = source[startIndex + 0];
            byte? max1 = source[startIndex + 1];
            byte? max2 = source[startIndex + 2];
            byte? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                byte? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                byte? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                byte? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static byte? Max<T>([NotNull] this T[] source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            byte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte? Max<T>([NotNull] this T[] source, [NotNull] Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            byte? max0 = mapFunc(source[startIndex + 0]);
            byte? max1 = mapFunc(source[startIndex + 1]);
            byte? max2 = mapFunc(source[startIndex + 2]);
            byte? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                byte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                byte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                byte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static byte? Max([NotNull] this List<byte?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            byte? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte? Max([NotNull] this List<byte?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            byte? max0 = source[startIndex + 0];
            byte? max1 = source[startIndex + 1];
            byte? max2 = source[startIndex + 2];
            byte? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                byte? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                byte? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                byte? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static byte? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            byte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            byte? max0 = mapFunc(source[startIndex + 0]);
            byte? max1 = mapFunc(source[startIndex + 1]);
            byte? max2 = mapFunc(source[startIndex + 2]);
            byte? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                byte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                byte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                byte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static byte? Max([NotNull] this IList<byte?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            byte? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte? Max([NotNull] this IList<byte?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            byte? max0 = source[startIndex + 0];
            byte? max1 = source[startIndex + 1];
            byte? max2 = source[startIndex + 2];
            byte? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                byte? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                byte? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                byte? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static byte? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            byte? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static byte? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            byte? max0 = mapFunc(source[startIndex + 0]);
            byte? max1 = mapFunc(source[startIndex + 1]);
            byte? max2 = mapFunc(source[startIndex + 2]);
            byte? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                byte? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                byte? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                byte? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                byte? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region short?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static short? Max([NotNull] this short?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            short? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short? Max([NotNull] this short?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            short? max0 = source[startIndex + 0];
            short? max1 = source[startIndex + 1];
            short? max2 = source[startIndex + 2];
            short? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                short? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                short? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                short? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static short? Max<T>([NotNull] this T[] source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            short? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short? Max<T>([NotNull] this T[] source, [NotNull] Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            short? max0 = mapFunc(source[startIndex + 0]);
            short? max1 = mapFunc(source[startIndex + 1]);
            short? max2 = mapFunc(source[startIndex + 2]);
            short? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                short? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                short? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                short? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static short? Max([NotNull] this List<short?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            short? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short? Max([NotNull] this List<short?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            short? max0 = source[startIndex + 0];
            short? max1 = source[startIndex + 1];
            short? max2 = source[startIndex + 2];
            short? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                short? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                short? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                short? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static short? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            short? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            short? max0 = mapFunc(source[startIndex + 0]);
            short? max1 = mapFunc(source[startIndex + 1]);
            short? max2 = mapFunc(source[startIndex + 2]);
            short? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                short? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                short? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                short? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static short? Max([NotNull] this IList<short?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            short? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short? Max([NotNull] this IList<short?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            short? max0 = source[startIndex + 0];
            short? max1 = source[startIndex + 1];
            short? max2 = source[startIndex + 2];
            short? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                short? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                short? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                short? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static short? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, short?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            short? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static short? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            short? max0 = mapFunc(source[startIndex + 0]);
            short? max1 = mapFunc(source[startIndex + 1]);
            short? max2 = mapFunc(source[startIndex + 2]);
            short? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                short? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                short? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                short? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                short? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region ushort?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ushort? Max([NotNull] this ushort?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            ushort? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort? Max([NotNull] this ushort?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            ushort? max0 = source[startIndex + 0];
            ushort? max1 = source[startIndex + 1];
            ushort? max2 = source[startIndex + 2];
            ushort? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ushort? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ushort? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ushort? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ushort? Max<T>([NotNull] this T[] source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            ushort? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort? Max<T>([NotNull] this T[] source, [NotNull] Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ushort? max0 = mapFunc(source[startIndex + 0]);
            ushort? max1 = mapFunc(source[startIndex + 1]);
            ushort? max2 = mapFunc(source[startIndex + 2]);
            ushort? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ushort? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ushort? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ushort? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ushort? Max([NotNull] this List<ushort?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            ushort? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort? Max([NotNull] this List<ushort?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            ushort? max0 = source[startIndex + 0];
            ushort? max1 = source[startIndex + 1];
            ushort? max2 = source[startIndex + 2];
            ushort? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ushort? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ushort? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ushort? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ushort? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            ushort? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ushort? max0 = mapFunc(source[startIndex + 0]);
            ushort? max1 = mapFunc(source[startIndex + 1]);
            ushort? max2 = mapFunc(source[startIndex + 2]);
            ushort? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ushort? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ushort? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ushort? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ushort? Max([NotNull] this IList<ushort?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            ushort? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort? Max([NotNull] this IList<ushort?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            ushort? max0 = source[startIndex + 0];
            ushort? max1 = source[startIndex + 1];
            ushort? max2 = source[startIndex + 2];
            ushort? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ushort? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ushort? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ushort? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ushort? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            ushort? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ushort? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ushort? max0 = mapFunc(source[startIndex + 0]);
            ushort? max1 = mapFunc(source[startIndex + 1]);
            ushort? max2 = mapFunc(source[startIndex + 2]);
            ushort? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ushort? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ushort? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ushort? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ushort? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region int?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static int? Max([NotNull] this int?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            int? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int? Max([NotNull] this int?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            int? max0 = source[startIndex + 0];
            int? max1 = source[startIndex + 1];
            int? max2 = source[startIndex + 2];
            int? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                int? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                int? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                int? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static int? Max<T>([NotNull] this T[] source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            int? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int? Max<T>([NotNull] this T[] source, [NotNull] Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            int? max0 = mapFunc(source[startIndex + 0]);
            int? max1 = mapFunc(source[startIndex + 1]);
            int? max2 = mapFunc(source[startIndex + 2]);
            int? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                int? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                int? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                int? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static int? Max([NotNull] this List<int?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            int? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int? Max([NotNull] this List<int?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            int? max0 = source[startIndex + 0];
            int? max1 = source[startIndex + 1];
            int? max2 = source[startIndex + 2];
            int? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                int? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                int? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                int? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static int? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            int? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            int? max0 = mapFunc(source[startIndex + 0]);
            int? max1 = mapFunc(source[startIndex + 1]);
            int? max2 = mapFunc(source[startIndex + 2]);
            int? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                int? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                int? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                int? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static int? Max([NotNull] this IList<int?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            int? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int? Max([NotNull] this IList<int?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            int? max0 = source[startIndex + 0];
            int? max1 = source[startIndex + 1];
            int? max2 = source[startIndex + 2];
            int? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                int? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                int? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                int? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static int? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, int?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            int? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static int? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            int? max0 = mapFunc(source[startIndex + 0]);
            int? max1 = mapFunc(source[startIndex + 1]);
            int? max2 = mapFunc(source[startIndex + 2]);
            int? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                int? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                int? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                int? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                int? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region uint?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static uint? Max([NotNull] this uint?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            uint? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint? Max([NotNull] this uint?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            uint? max0 = source[startIndex + 0];
            uint? max1 = source[startIndex + 1];
            uint? max2 = source[startIndex + 2];
            uint? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                uint? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                uint? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                uint? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static uint? Max<T>([NotNull] this T[] source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            uint? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint? Max<T>([NotNull] this T[] source, [NotNull] Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            uint? max0 = mapFunc(source[startIndex + 0]);
            uint? max1 = mapFunc(source[startIndex + 1]);
            uint? max2 = mapFunc(source[startIndex + 2]);
            uint? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                uint? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                uint? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                uint? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static uint? Max([NotNull] this List<uint?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            uint? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint? Max([NotNull] this List<uint?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            uint? max0 = source[startIndex + 0];
            uint? max1 = source[startIndex + 1];
            uint? max2 = source[startIndex + 2];
            uint? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                uint? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                uint? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                uint? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static uint? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            uint? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            uint? max0 = mapFunc(source[startIndex + 0]);
            uint? max1 = mapFunc(source[startIndex + 1]);
            uint? max2 = mapFunc(source[startIndex + 2]);
            uint? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                uint? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                uint? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                uint? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static uint? Max([NotNull] this IList<uint?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            uint? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint? Max([NotNull] this IList<uint?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            uint? max0 = source[startIndex + 0];
            uint? max1 = source[startIndex + 1];
            uint? max2 = source[startIndex + 2];
            uint? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                uint? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                uint? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                uint? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static uint? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            uint? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static uint? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            uint? max0 = mapFunc(source[startIndex + 0]);
            uint? max1 = mapFunc(source[startIndex + 1]);
            uint? max2 = mapFunc(source[startIndex + 2]);
            uint? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                uint? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                uint? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                uint? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                uint? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region long?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static long? Max([NotNull] this long?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            long? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long? Max([NotNull] this long?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            long? max0 = source[startIndex + 0];
            long? max1 = source[startIndex + 1];
            long? max2 = source[startIndex + 2];
            long? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                long? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                long? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                long? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static long? Max<T>([NotNull] this T[] source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            long? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long? Max<T>([NotNull] this T[] source, [NotNull] Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            long? max0 = mapFunc(source[startIndex + 0]);
            long? max1 = mapFunc(source[startIndex + 1]);
            long? max2 = mapFunc(source[startIndex + 2]);
            long? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                long? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                long? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                long? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static long? Max([NotNull] this List<long?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            long? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long? Max([NotNull] this List<long?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            long? max0 = source[startIndex + 0];
            long? max1 = source[startIndex + 1];
            long? max2 = source[startIndex + 2];
            long? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                long? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                long? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                long? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static long? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            long? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            long? max0 = mapFunc(source[startIndex + 0]);
            long? max1 = mapFunc(source[startIndex + 1]);
            long? max2 = mapFunc(source[startIndex + 2]);
            long? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                long? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                long? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                long? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static long? Max([NotNull] this IList<long?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            long? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long? Max([NotNull] this IList<long?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            long? max0 = source[startIndex + 0];
            long? max1 = source[startIndex + 1];
            long? max2 = source[startIndex + 2];
            long? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                long? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                long? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                long? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static long? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, long?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            long? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static long? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            long? max0 = mapFunc(source[startIndex + 0]);
            long? max1 = mapFunc(source[startIndex + 1]);
            long? max2 = mapFunc(source[startIndex + 2]);
            long? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                long? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                long? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                long? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                long? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region ulong?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ulong? Max([NotNull] this ulong?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            ulong? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong? Max([NotNull] this ulong?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            ulong? max0 = source[startIndex + 0];
            ulong? max1 = source[startIndex + 1];
            ulong? max2 = source[startIndex + 2];
            ulong? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ulong? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ulong? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ulong? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ulong? Max<T>([NotNull] this T[] source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            ulong? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong? Max<T>([NotNull] this T[] source, [NotNull] Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ulong? max0 = mapFunc(source[startIndex + 0]);
            ulong? max1 = mapFunc(source[startIndex + 1]);
            ulong? max2 = mapFunc(source[startIndex + 2]);
            ulong? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ulong? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ulong? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ulong? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ulong? Max([NotNull] this List<ulong?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            ulong? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong? Max([NotNull] this List<ulong?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            ulong? max0 = source[startIndex + 0];
            ulong? max1 = source[startIndex + 1];
            ulong? max2 = source[startIndex + 2];
            ulong? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ulong? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ulong? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ulong? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ulong? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            ulong? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ulong? max0 = mapFunc(source[startIndex + 0]);
            ulong? max1 = mapFunc(source[startIndex + 1]);
            ulong? max2 = mapFunc(source[startIndex + 2]);
            ulong? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ulong? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ulong? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ulong? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static ulong? Max([NotNull] this IList<ulong?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            ulong? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong? Max([NotNull] this IList<ulong?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            ulong? max0 = source[startIndex + 0];
            ulong? max1 = source[startIndex + 1];
            ulong? max2 = source[startIndex + 2];
            ulong? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ulong? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ulong? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ulong? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static ulong? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            ulong? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static ulong? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            ulong? max0 = mapFunc(source[startIndex + 0]);
            ulong? max1 = mapFunc(source[startIndex + 1]);
            ulong? max2 = mapFunc(source[startIndex + 2]);
            ulong? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                ulong? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                ulong? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                ulong? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                ulong? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region float?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static float? Max([NotNull] this float?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            float? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float? Max([NotNull] this float?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            float? max0 = source[startIndex + 0];
            float? max1 = source[startIndex + 1];
            float? max2 = source[startIndex + 2];
            float? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                float? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                float? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                float? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static float? Max<T>([NotNull] this T[] source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            float? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float? Max<T>([NotNull] this T[] source, [NotNull] Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            float? max0 = mapFunc(source[startIndex + 0]);
            float? max1 = mapFunc(source[startIndex + 1]);
            float? max2 = mapFunc(source[startIndex + 2]);
            float? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                float? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                float? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                float? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static float? Max([NotNull] this List<float?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            float? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float? Max([NotNull] this List<float?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            float? max0 = source[startIndex + 0];
            float? max1 = source[startIndex + 1];
            float? max2 = source[startIndex + 2];
            float? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                float? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                float? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                float? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static float? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            float? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            float? max0 = mapFunc(source[startIndex + 0]);
            float? max1 = mapFunc(source[startIndex + 1]);
            float? max2 = mapFunc(source[startIndex + 2]);
            float? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                float? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                float? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                float? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static float? Max([NotNull] this IList<float?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            float? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float? Max([NotNull] this IList<float?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            float? max0 = source[startIndex + 0];
            float? max1 = source[startIndex + 1];
            float? max2 = source[startIndex + 2];
            float? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                float? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                float? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                float? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static float? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, float?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            float? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static float? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            float? max0 = mapFunc(source[startIndex + 0]);
            float? max1 = mapFunc(source[startIndex + 1]);
            float? max2 = mapFunc(source[startIndex + 2]);
            float? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                float? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                float? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                float? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                float? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region double?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static double? Max([NotNull] this double?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            double? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double? Max([NotNull] this double?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            double? max0 = source[startIndex + 0];
            double? max1 = source[startIndex + 1];
            double? max2 = source[startIndex + 2];
            double? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                double? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                double? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                double? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static double? Max<T>([NotNull] this T[] source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            double? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double? Max<T>([NotNull] this T[] source, [NotNull] Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            double? max0 = mapFunc(source[startIndex + 0]);
            double? max1 = mapFunc(source[startIndex + 1]);
            double? max2 = mapFunc(source[startIndex + 2]);
            double? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                double? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                double? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                double? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static double? Max([NotNull] this List<double?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            double? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double? Max([NotNull] this List<double?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            double? max0 = source[startIndex + 0];
            double? max1 = source[startIndex + 1];
            double? max2 = source[startIndex + 2];
            double? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                double? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                double? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                double? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static double? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            double? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            double? max0 = mapFunc(source[startIndex + 0]);
            double? max1 = mapFunc(source[startIndex + 1]);
            double? max2 = mapFunc(source[startIndex + 2]);
            double? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                double? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                double? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                double? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static double? Max([NotNull] this IList<double?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            double? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double? Max([NotNull] this IList<double?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            double? max0 = source[startIndex + 0];
            double? max1 = source[startIndex + 1];
            double? max2 = source[startIndex + 2];
            double? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                double? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                double? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                double? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static double? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, double?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            double? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static double? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            double? max0 = mapFunc(source[startIndex + 0]);
            double? max1 = mapFunc(source[startIndex + 1]);
            double? max2 = mapFunc(source[startIndex + 2]);
            double? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                double? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                double? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                double? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                double? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
            if (!y.HasValue)
                return x; //y is null so return x              
            if (!x.HasValue)
                return y; //x is null so return y
            return Math.Max(x.Value, y.Value); //return max of x and y            
        }
        
        #region decimal?             
              

        /// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static decimal? Max([NotNull] this decimal?[] source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Length);         
            }                
            decimal? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal? Max([NotNull] this decimal?[] source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            decimal? max0 = source[startIndex + 0];
            decimal? max1 = source[startIndex + 1];
            decimal? max2 = source[startIndex + 2];
            decimal? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                decimal? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                decimal? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                decimal? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static decimal? Max<T>([NotNull] this T[] source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Length < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Length);         
            }                
            decimal? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal? Max<T>([NotNull] this T[] source, [NotNull] Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            decimal? max0 = mapFunc(source[startIndex + 0]);
            decimal? max1 = mapFunc(source[startIndex + 1]);
            decimal? max2 = mapFunc(source[startIndex + 2]);
            decimal? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                decimal? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                decimal? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                decimal? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static decimal? Max([NotNull] this List<decimal?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            decimal? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal? Max([NotNull] this List<decimal?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            decimal? max0 = source[startIndex + 0];
            decimal? max1 = source[startIndex + 1];
            decimal? max2 = source[startIndex + 2];
            decimal? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                decimal? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                decimal? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                decimal? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static decimal? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            decimal? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal? Max<T>([NotNull] this List<T> source, [NotNull] Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            decimal? max0 = mapFunc(source[startIndex + 0]);
            decimal? max1 = mapFunc(source[startIndex + 1]);
            decimal? max2 = mapFunc(source[startIndex + 2]);
            decimal? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                decimal? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                decimal? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                decimal? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>        
        /// <returns>Maximum value of mapping</returns>
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
        [Pure]
        public static decimal? Max([NotNull] this IList<decimal?> source)
        {
            source.IsNotNull(nameof(source));
            
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, 0, source.Count);         
            }                
            decimal? result = source.First();
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal? Max([NotNull] this IList<decimal?> source, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return source[0];  
                case 2:
                    return Max(source[0], source[1]);  
                case 3:
                    return Max(source[0], Max(source[1], source[2]));  
                case 4:
                    return Max(Max(source[0], source[1]), Max(source[2], source[3]));    
                }
            }
            decimal? max0 = source[startIndex + 0];
            decimal? max1 = source[startIndex + 1];
            decimal? max2 = source[startIndex + 2];
            decimal? max3 = source[startIndex + 3];
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = source[i + 0];
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                decimal? arg1 = source[i + 1];
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                decimal? arg2 = source[i + 2];
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                decimal? arg3 = source[i + 3];
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception> 
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure]
        public static decimal? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal?> mapFunc)
        {
            source.IsNotNull(nameof(source));
            mapFunc.IsNotNull(nameof(mapFunc));
            source.IsNotEmpty();
            if (source.Count < Constants.SingleThreadExecutionThreshold)
            {
                return Max(source, mapFunc, 0, source.Count);         
            }                
            decimal? result = mapFunc(source.First());
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                range => 
                {
                    var x = Max(source, mapFunc, range.Item1, range.Item2);
                    if (x.HasValue && (result < x || !result.HasValue))
                    {
                        lock (syncRoot)
                        {
                            if (result < x || !result.HasValue)
                                result = x;
                        }
                    }
                });

            return result;
        }

        [Pure]
        private static decimal? Max<T>([NotNull] this IList<T> source, [NotNull] Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
            int diff = endIndex - startIndex;
            if (diff <= Constants.Step)
            {
                switch (diff)
                {     
                case 1:
                    return mapFunc(source[0]);  
                case 2:
                    return Max(mapFunc(source[0]), mapFunc(source[1]));  
                case 3:
                    return Max(mapFunc(source[0]), Max(mapFunc(source[1]), mapFunc(source[2])));  
                case 4:
                    return Max(Max(mapFunc(source[0]), mapFunc(source[1])), Max(mapFunc(source[2]), mapFunc(source[3])));    
                }
            }
            decimal? max0 = mapFunc(source[startIndex + 0]);
            decimal? max1 = mapFunc(source[startIndex + 1]);
            decimal? max2 = mapFunc(source[startIndex + 2]);
            decimal? max3 = mapFunc(source[startIndex + 3]);
              
          
            int i;
            int loopEnd = endIndex - Constants.Step + 1;
            for (i = startIndex; i < loopEnd; i += Constants.Step)
            {
                decimal? arg0 = mapFunc(source[i + 0]);
                if (arg0.HasValue && (max0 < arg0 || !max0.HasValue))
                    max0 = arg0.GetValueOrDefault();
                decimal? arg1 = mapFunc(source[i + 1]);
                if (arg1.HasValue && (max1 < arg1 || !max1.HasValue))
                    max1 = arg1.GetValueOrDefault();
                decimal? arg2 = mapFunc(source[i + 2]);
                if (arg2.HasValue && (max2 < arg2 || !max2.HasValue))
                    max2 = arg2.GetValueOrDefault();
                decimal? arg3 = mapFunc(source[i + 3]);
                if (arg3.HasValue && (max3 < arg3 || !max3.HasValue))
                    max3 = arg3.GetValueOrDefault();
                
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
