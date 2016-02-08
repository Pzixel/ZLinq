
using System;
using System.Collections.Generic;
using JetBrains.Annotations;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
            

        [Pure]
        public static int[] Repeat(this Random random, int count)
        {
            return Repeat(random, r => r.Next(), count);
        }

        [Pure]
        public static int[] Repeat(this Random random, int count, int max)
        {
            return Repeat(random, r => r.Next(max), count);
        }

        [Pure]
        public static int[] Repeat(this Random random, int count, int min, int max)
        {
            return Repeat(random, r => r.Next(min, max), count);
        }

        [Pure]
        public static double[] RepeatDouble(this Random random, int count)
        {
            return Repeat(random, r => r.NextDouble(), count);
        }

            

        [Pure]
        public static List<int> RepeatList(this Random random, int count)
        {
            return RepeatList(random, r => r.Next(), count);
        }

        [Pure]
        public static List<int> RepeatList(this Random random, int count, int max)
        {
            return RepeatList(random, r => r.Next(max), count);
        }

        [Pure]
        public static List<int> RepeatList(this Random random, int count, int min, int max)
        {
            return RepeatList(random, r => r.Next(min, max), count);
        }

        [Pure]
        public static List<double> RepeatDoubleList(this Random random, int count)
        {
            return RepeatList(random, r => r.NextDouble(), count);
        }

            

        [Pure]
        public static IEnumerable<int> RepeatSeq(this Random random, int count)
        {
            return RepeatSeq(random, r => r.Next(), count);
        }

        [Pure]
        public static IEnumerable<int> RepeatSeq(this Random random, int count, int max)
        {
            return RepeatSeq(random, r => r.Next(max), count);
        }

        [Pure]
        public static IEnumerable<int> RepeatSeq(this Random random, int count, int min, int max)
        {
            return RepeatSeq(random, r => r.Next(min, max), count);
        }

        [Pure]
        public static IEnumerable<double> RepeatDoubleSeq(this Random random, int count)
        {
            return RepeatSeq(random, r => r.NextDouble(), count);
        }

            
    }
}
