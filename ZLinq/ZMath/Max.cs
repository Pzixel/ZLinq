
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using ZLinq.Extension;

// ReSharper disable CheckNamespace
// ReSharper disable RedundantCast
namespace ZLinq
{
    public static partial class ZEnumerable
    {
		
		#region sbyte	 		
			
		/// <summary>
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static sbyte Max(this sbyte[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (sbyte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max(this sbyte[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            sbyte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static sbyte Max<T>(this T[] source, Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (sbyte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max<T>(this T[] source, Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            sbyte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                sbyte tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                sbyte tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                sbyte tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                sbyte tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static sbyte Max(this List<sbyte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (sbyte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max(this List<sbyte> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            sbyte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static sbyte Max<T>(this List<T> source, Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (sbyte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max<T>(this List<T> source, Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            sbyte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                sbyte tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                sbyte tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                sbyte tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                sbyte tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static sbyte Max(this IList<sbyte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (sbyte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max(this IList<sbyte> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            sbyte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static sbyte Max<T>(this IList<T> source, Func<T, sbyte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (sbyte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max<T>(this IList<T> source, Func<T, sbyte> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            sbyte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                sbyte tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                sbyte tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                sbyte tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                sbyte tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static byte Max(this byte[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (byte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max(this byte[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            byte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static byte Max<T>(this T[] source, Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (byte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max<T>(this T[] source, Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            byte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                byte tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                byte tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                byte tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                byte tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static byte Max(this List<byte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (byte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max(this List<byte> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            byte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static byte Max<T>(this List<T> source, Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (byte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max<T>(this List<T> source, Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            byte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                byte tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                byte tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                byte tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                byte tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static byte Max(this IList<byte> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (byte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max(this IList<byte> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            byte max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static byte Max<T>(this IList<T> source, Func<T, byte> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (byte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max<T>(this IList<T> source, Func<T, byte> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            byte max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                byte tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                byte tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                byte tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                byte tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static short Max(this short[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (short)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max(this short[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            short max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static short Max<T>(this T[] source, Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (short)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max<T>(this T[] source, Func<T, short> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            short max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                short tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                short tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                short tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                short tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static short Max(this List<short> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (short)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max(this List<short> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            short max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static short Max<T>(this List<T> source, Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (short)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max<T>(this List<T> source, Func<T, short> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            short max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                short tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                short tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                short tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                short tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static short Max(this IList<short> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (short)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max(this IList<short> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            short max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static short Max<T>(this IList<T> source, Func<T, short> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (short)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max<T>(this IList<T> source, Func<T, short> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            short max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                short tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                short tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                short tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                short tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ushort Max(this ushort[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (ushort)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max(this ushort[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            ushort max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ushort Max<T>(this T[] source, Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (ushort)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max<T>(this T[] source, Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            ushort max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                ushort tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                ushort tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                ushort tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                ushort tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ushort Max(this List<ushort> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ushort)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max(this List<ushort> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            ushort max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ushort Max<T>(this List<T> source, Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ushort)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max<T>(this List<T> source, Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            ushort max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                ushort tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                ushort tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                ushort tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                ushort tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ushort Max(this IList<ushort> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ushort)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max(this IList<ushort> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            ushort max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ushort Max<T>(this IList<T> source, Func<T, ushort> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ushort)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max<T>(this IList<T> source, Func<T, ushort> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            ushort max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                ushort tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                ushort tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                ushort tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                ushort tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static int Max(this int[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (int)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max(this int[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            int max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static int Max<T>(this T[] source, Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (int)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max<T>(this T[] source, Func<T, int> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            int max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                int tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                int tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                int tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                int tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static int Max(this List<int> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (int)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max(this List<int> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            int max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static int Max<T>(this List<T> source, Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (int)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max<T>(this List<T> source, Func<T, int> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            int max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                int tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                int tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                int tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                int tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static int Max(this IList<int> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (int)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max(this IList<int> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            int max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static int Max<T>(this IList<T> source, Func<T, int> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (int)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max<T>(this IList<T> source, Func<T, int> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            int max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                int tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                int tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                int tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                int tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static uint Max(this uint[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (uint)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max(this uint[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            uint max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static uint Max<T>(this T[] source, Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (uint)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max<T>(this T[] source, Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            uint max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                uint tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                uint tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                uint tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                uint tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static uint Max(this List<uint> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (uint)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max(this List<uint> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            uint max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static uint Max<T>(this List<T> source, Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (uint)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max<T>(this List<T> source, Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            uint max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                uint tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                uint tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                uint tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                uint tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static uint Max(this IList<uint> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (uint)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max(this IList<uint> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            uint max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static uint Max<T>(this IList<T> source, Func<T, uint> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (uint)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max<T>(this IList<T> source, Func<T, uint> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            uint max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                uint tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                uint tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                uint tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                uint tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static long Max(this long[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (long)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max(this long[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            long max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static long Max<T>(this T[] source, Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (long)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max<T>(this T[] source, Func<T, long> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            long max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                long tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                long tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                long tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                long tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static long Max(this List<long> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (long)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max(this List<long> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            long max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static long Max<T>(this List<T> source, Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (long)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max<T>(this List<T> source, Func<T, long> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            long max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                long tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                long tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                long tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                long tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static long Max(this IList<long> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (long)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max(this IList<long> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            long max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static long Max<T>(this IList<T> source, Func<T, long> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (long)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max<T>(this IList<T> source, Func<T, long> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            long max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                long tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                long tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                long tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                long tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static float Max(this float[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (float)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max(this float[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            float max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static float Max<T>(this T[] source, Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (float)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max<T>(this T[] source, Func<T, float> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            float max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                float tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                float tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                float tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                float tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static float Max(this List<float> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (float)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max(this List<float> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            float max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static float Max<T>(this List<T> source, Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (float)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max<T>(this List<T> source, Func<T, float> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            float max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                float tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                float tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                float tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                float tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static float Max(this IList<float> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (float)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max(this IList<float> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            float max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static float Max<T>(this IList<T> source, Func<T, float> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (float)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max<T>(this IList<T> source, Func<T, float> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            float max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                float tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                float tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                float tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                float tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static double Max(this double[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (double)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max(this double[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            double max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static double Max<T>(this T[] source, Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (double)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max<T>(this T[] source, Func<T, double> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            double max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                double tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                double tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                double tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                double tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static double Max(this List<double> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (double)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max(this List<double> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            double max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static double Max<T>(this List<T> source, Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (double)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max<T>(this List<T> source, Func<T, double> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            double max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                double tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                double tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                double tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                double tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static double Max(this IList<double> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (double)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max(this IList<double> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            double max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static double Max<T>(this IList<T> source, Func<T, double> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (double)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max<T>(this IList<T> source, Func<T, double> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            double max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                double tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                double tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                double tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                double tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static decimal Max(this decimal[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (decimal)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max(this decimal[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            decimal max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static decimal Max<T>(this T[] source, Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (decimal)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max<T>(this T[] source, Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            decimal max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                decimal tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                decimal tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                decimal tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                decimal tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static decimal Max(this List<decimal> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (decimal)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max(this List<decimal> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            decimal max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static decimal Max<T>(this List<T> source, Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (decimal)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max<T>(this List<T> source, Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            decimal max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                decimal tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                decimal tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                decimal tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                decimal tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static decimal Max(this IList<decimal> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (decimal)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max(this IList<decimal> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            decimal max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static decimal Max<T>(this IList<T> source, Func<T, decimal> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (decimal)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max<T>(this IList<T> source, Func<T, decimal> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            decimal max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                decimal tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                decimal tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                decimal tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                decimal tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ulong Max(this ulong[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (ulong)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max(this ulong[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0];
		        if (source.Length == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Length == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            ulong max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ulong Max<T>(this T[] source, Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (ulong)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max<T>(this T[] source, Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]);
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            ulong max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                ulong tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                ulong tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                ulong tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                ulong tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ulong Max(this List<ulong> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ulong)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max(this List<ulong> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            ulong max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ulong Max<T>(this List<T> source, Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ulong)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max<T>(this List<T> source, Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            ulong max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                ulong tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                ulong tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                ulong tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                ulong tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
        /// Search max value in collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ulong Max(this IList<ulong> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ulong)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max(this IList<ulong> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0];
		        if (source.Count == 2)
		            return Math.Max(source[0], source[1]);
                if (source.Count == 3)
                    return Math.Max(source[0], Math.Max(source[1], source[2]));
                return Math.Max(Math.Max(source[0], source[1]), Math.Max(source[2], source[3]));
            }
            ulong max0 = source[startIndex], max1 = source[startIndex + 1], max2 = source[startIndex + 2], max3 = source[startIndex + 3];
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                if (max0 < source[i])
                    max0 = source[i];
                if (max1 < source[i + 1])
                    max1 = source[i + 1];
                if (max2 < source[i + 2])
                    max2 = source[i + 2];
                if (max3 < source[i + 3])
                    max3 = source[i + 3];   
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
        /// Search max value in mapped collection
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ulong Max<T>(this IList<T> source, Func<T, ulong> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ulong)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max<T>(this IList<T> source, Func<T, ulong> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]);
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]), mapFunc(source[1]));
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]), Math.Max(mapFunc(source[1]), mapFunc(source[2])));
                return Math.Max(Math.Max(mapFunc(source[0]), mapFunc(source[1])), Math.Max(mapFunc(source[2]), mapFunc(source[3])));
            }
            ulong max0 = mapFunc(source[startIndex]), max1 = mapFunc(source[startIndex + 1]), 
                max2 = mapFunc(source[startIndex + 2]), max3 = mapFunc(source[startIndex + 3]);

            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
            {
                ulong tmp0 = mapFunc(source[i]);
                if (max0 < tmp0)
                    max0 = tmp0;
                ulong tmp1 = mapFunc(source[i + 1]);
                if (max1 < tmp1)
                    max1 = tmp1;
                ulong tmp2 = mapFunc(source[i + 2]);
                if (max2 < tmp2)
                    max2 = tmp2;
                ulong tmp3 = mapFunc(source[i + 3]);
                if (max3 < tmp3)
                    max3 = tmp3;
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
		

	#region Nullables

		
		#region sbyte	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static sbyte Max(this sbyte?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (sbyte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max(this sbyte?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            sbyte max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static sbyte Max<T>(this T[] source, Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (sbyte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max<T>(this T[] source, Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            sbyte max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static sbyte Max(this List<sbyte?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (sbyte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max(this List<sbyte?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            sbyte max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static sbyte Max<T>(this List<T> source, Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (sbyte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max<T>(this List<T> source, Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            sbyte max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static sbyte Max(this IList<sbyte?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (sbyte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max(this IList<sbyte?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            sbyte max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static sbyte Max<T>(this IList<T> source, Func<T, sbyte?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            sbyte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (sbyte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static sbyte Max<T>(this IList<T> source, Func<T, sbyte?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            sbyte max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (sbyte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (sbyte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
	
		#region byte	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static byte Max(this byte?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (byte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max(this byte?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            byte max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static byte Max<T>(this T[] source, Func<T, byte?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (byte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max<T>(this T[] source, Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            byte max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static byte Max(this List<byte?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (byte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max(this List<byte?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            byte max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static byte Max<T>(this List<T> source, Func<T, byte?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (byte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max<T>(this List<T> source, Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            byte max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static byte Max(this IList<byte?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (byte)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max(this IList<byte?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            byte max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static byte Max<T>(this IList<T> source, Func<T, byte?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            byte result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (byte)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static byte Max<T>(this IList<T> source, Func<T, byte?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            byte max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (byte) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (byte) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
	
		#region short	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static short Max(this short?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (short)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max(this short?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            short max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static short Max<T>(this T[] source, Func<T, short?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (short)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max<T>(this T[] source, Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            short max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static short Max(this List<short?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (short)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max(this List<short?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            short max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static short Max<T>(this List<T> source, Func<T, short?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (short)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max<T>(this List<T> source, Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            short max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static short Max(this IList<short?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (short)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max(this IList<short?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            short max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static short Max<T>(this IList<T> source, Func<T, short?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (short)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static short Max<T>(this IList<T> source, Func<T, short?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            short max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (short) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (short) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
	
		#region ushort	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ushort Max(this ushort?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (ushort)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max(this ushort?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            ushort max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ushort Max<T>(this T[] source, Func<T, ushort?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (ushort)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max<T>(this T[] source, Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            ushort max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ushort Max(this List<ushort?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ushort)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max(this List<ushort?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            ushort max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ushort Max<T>(this List<T> source, Func<T, ushort?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ushort)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max<T>(this List<T> source, Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            ushort max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ushort Max(this IList<ushort?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ushort)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max(this IList<ushort?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            ushort max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ushort Max<T>(this IList<T> source, Func<T, ushort?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            ushort result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ushort)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ushort Max<T>(this IList<T> source, Func<T, ushort?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            ushort max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return (ushort) Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return (ushort) Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
	
		#region int	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static int Max(this int?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (int)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max(this int?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            int max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static int Max<T>(this T[] source, Func<T, int?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (int)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max<T>(this T[] source, Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            int max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static int Max(this List<int?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (int)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max(this List<int?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            int max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static int Max<T>(this List<T> source, Func<T, int?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (int)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max<T>(this List<T> source, Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            int max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static int Max(this IList<int?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (int)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max(this IList<int?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            int max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static int Max<T>(this IList<T> source, Func<T, int?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (int)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static int Max<T>(this IList<T> source, Func<T, int?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            int max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
	
		#region uint	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static uint Max(this uint?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (uint)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max(this uint?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            uint max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static uint Max<T>(this T[] source, Func<T, uint?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (uint)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max<T>(this T[] source, Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            uint max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static uint Max(this List<uint?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (uint)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max(this List<uint?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            uint max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static uint Max<T>(this List<T> source, Func<T, uint?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (uint)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max<T>(this List<T> source, Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            uint max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static uint Max(this IList<uint?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (uint)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max(this IList<uint?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            uint max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static uint Max<T>(this IList<T> source, Func<T, uint?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            uint result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (uint)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static uint Max<T>(this IList<T> source, Func<T, uint?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            uint max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
	
		#region long	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static long Max(this long?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (long)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max(this long?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            long max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static long Max<T>(this T[] source, Func<T, long?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (long)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max<T>(this T[] source, Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            long max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static long Max(this List<long?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (long)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max(this List<long?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            long max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static long Max<T>(this List<T> source, Func<T, long?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (long)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max<T>(this List<T> source, Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            long max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static long Max(this IList<long?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (long)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max(this IList<long?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            long max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static long Max<T>(this IList<T> source, Func<T, long?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (long)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static long Max<T>(this IList<T> source, Func<T, long?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            long max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
	
		#region float	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static float Max(this float?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (float)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max(this float?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            float max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static float Max<T>(this T[] source, Func<T, float?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (float)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max<T>(this T[] source, Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            float max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static float Max(this List<float?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (float)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max(this List<float?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            float max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static float Max<T>(this List<T> source, Func<T, float?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (float)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max<T>(this List<T> source, Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            float max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static float Max(this IList<float?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (float)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max(this IList<float?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            float max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static float Max<T>(this IList<T> source, Func<T, float?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            float result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (float)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static float Max<T>(this IList<T> source, Func<T, float?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            float max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
	
		#region double	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static double Max(this double?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (double)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max(this double?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            double max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static double Max<T>(this T[] source, Func<T, double?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (double)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max<T>(this T[] source, Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            double max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static double Max(this List<double?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (double)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max(this List<double?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            double max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static double Max<T>(this List<T> source, Func<T, double?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (double)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max<T>(this List<T> source, Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            double max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static double Max(this IList<double?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (double)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max(this IList<double?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            double max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static double Max<T>(this IList<T> source, Func<T, double?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            double result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (double)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static double Max<T>(this IList<T> source, Func<T, double?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            double max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
	
		#region decimal	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static decimal Max(this decimal?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (decimal)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max(this decimal?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            decimal max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static decimal Max<T>(this T[] source, Func<T, decimal?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (decimal)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max<T>(this T[] source, Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            decimal max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static decimal Max(this List<decimal?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (decimal)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max(this List<decimal?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            decimal max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static decimal Max<T>(this List<T> source, Func<T, decimal?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (decimal)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max<T>(this List<T> source, Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            decimal max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static decimal Max(this IList<decimal?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (decimal)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max(this IList<decimal?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            decimal max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static decimal Max<T>(this IList<T> source, Func<T, decimal?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            decimal result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (decimal)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static decimal Max<T>(this IList<T> source, Func<T, decimal?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            decimal max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
	
		#region ulong	 		
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ulong Max(this ulong?[] source)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Length);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (ulong)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max(this ulong?[] source, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            ulong max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ulong Max<T>(this T[] source, Func<T, ulong?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Length < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Length);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                () => (ulong)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max<T>(this T[] source, Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Length <= 4)
		    {
		        if (source.Length == 0)
		            return 0;
		        if (source.Length == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Length == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Length == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            ulong max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Length - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Length - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ulong Max(this List<ulong?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ulong)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max(this List<ulong?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            ulong max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ulong Max<T>(this List<T> source, Func<T, ulong?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ulong)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max<T>(this List<T> source, Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            ulong max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
			
		/// <summary>
        /// Search max value in collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <returns>Maximum value of collection</returns>
		[Pure]
        public static ulong Max(this IList<ulong?> source)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ulong)0,
                (range, state, max) => Max(source, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max(this IList<ulong?> source, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return source[0].GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(source[0].GetValueOrDefault(), Math.Max(source[1].GetValueOrDefault(), source[2].GetValueOrDefault()));
                return Math.Max(Math.Max(source[0].GetValueOrDefault(), source[1].GetValueOrDefault()), Math.Max(source[2].GetValueOrDefault(), source[3].GetValueOrDefault()));
            }
            ulong max0 = source[startIndex].GetValueOrDefault(), max1 = source[startIndex + 1].GetValueOrDefault(), max2 = source[startIndex + 2].GetValueOrDefault(), max3 = source[startIndex + 3].GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), source[i].GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), source[i + 1].GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(source[i].GetValueOrDefault(), Math.Max(source[i + 1].GetValueOrDefault(), source[i + 2].GetValueOrDefault())));
        } 

		/// <summary>
        /// Search max value in mapped collection or zero if all items are null
        /// </summary>
        /// <param name="source">Source collection</param>
        /// <param name="mapFunc">Function that maps each element of source to perform search</param>
        /// <returns>Maximum value of mapping</returns>
		[Pure]
        public static ulong Max<T>(this IList<T> source, Func<T, ulong?> mapFunc)
        {
            source.IsNotNull("source");
            if (source.Count < Constants.SingleThreadExecutionThreshold)
                return Max(source, mapFunc, 0, source.Count);
            ulong result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Count),
                () => (ulong)0,
                (range, state, max) => Max(source, mapFunc, range.Item1, range.Item2),
                x =>
                {
                    lock (syncRoot)
                        if (result < x)
                            result = x;
                });

            return result;
        }

		[Pure]
        private static ulong Max<T>(this IList<T> source, Func<T, ulong?> mapFunc, int startIndex, int endIndex)
        {
			if (source.Count <= 4)
		    {
		        if (source.Count == 0)
		            return 0;
		        if (source.Count == 1)
		            return mapFunc(source[0]).GetValueOrDefault();
		        if (source.Count == 2)
		            return Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault());
                if (source.Count == 3)
                    return Math.Max(mapFunc(source[0]).GetValueOrDefault(), Math.Max(mapFunc(source[1]).GetValueOrDefault(), mapFunc(source[2]).GetValueOrDefault()));
                return Math.Max(Math.Max(mapFunc(source[0]).GetValueOrDefault(), mapFunc(source[1]).GetValueOrDefault()), Math.Max(mapFunc(source[2]).GetValueOrDefault(), mapFunc(source[3]).GetValueOrDefault()));
            }
            ulong max0 = mapFunc(source[startIndex]).GetValueOrDefault(), max1 = mapFunc(source[startIndex + 1]).GetValueOrDefault(), max2 = mapFunc(source[startIndex + 2]).GetValueOrDefault(), max3 = mapFunc(source[startIndex + 3]).GetValueOrDefault();
            int i;
            for (i = startIndex; i < endIndex - Constants.Step + 1; i += Constants.Step)
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
                return  Math.Max(Math.Max(max0, max1), Math.Max(max2, max3));
            if (i == source.Count - 1)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), mapFunc(source[i]).GetValueOrDefault());
            if (i == source.Count - 2)
                return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), mapFunc(source[i + 1]).GetValueOrDefault()));
            return  Math.Max(Math.Max(Math.Max(max0, max1), Math.Max(max2, max3)), Math.Max(mapFunc(source[i]).GetValueOrDefault(), Math.Max(mapFunc(source[i + 1]).GetValueOrDefault(), mapFunc(source[i + 2]).GetValueOrDefault())));
        } 
		
		#endregion
		

	#endregion
    }
}
