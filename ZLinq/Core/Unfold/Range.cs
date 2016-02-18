using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
        [Pure]
        public static int[] Range(int start, int count)
        {
            long num = (long) start + count - 1L;
            if (count < 0 || num > int.MaxValue)
                throw new ArgumentOutOfRangeException();
            int[] result = new int[count];
            for (int i = 0, j = start; i < result.Length; i++, j++)
                result[i] = j;
            return result;
        }

        [Pure]
        public static T[] Range<T>(int start, int count, Func<int, T> generator)
        {
            long num = (long)start + count - 1L;
            if (count < 0 || num > int.MaxValue)
                throw new ArgumentOutOfRangeException();
            T[] result = new T[count];
            for (int i = 0, j = start; i < result.Length; i++, j++)
                result[i] = generator(j);
            return result;
        }

        [Pure]
        public static IEnumerable<T> RangeSeq<T>(int start, int count, Func<int, T> generator)
        {
            long num = (long)start + count - 1L;
            if (count < 0 || num > int.MaxValue)
                throw new ArgumentOutOfRangeException();
            for (int i = 0, j = start; i < count; i++, j++)
                yield return generator(j);
        }
    }
}
