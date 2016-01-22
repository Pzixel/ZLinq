using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
        [Pure]
        public static T[] Repeat<T>(T value, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            T[] result = new T[count];
            for (int i = 0; i < result.Length; i++)
                result[i] = value;
            return result;
        }

        [Pure]
        public static T[] Repeat<T, TSource>(TSource generator, Func<TSource, T> func, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            T[] result = new T[count];
            for (int i = 0; i < result.Length; i++)
                result[i] = func(generator);
            return result;
        }

        [Pure]
        public static T[] Repeat<T>(Func<T> func, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            T[] result = new T[count];
            for (int i = 0; i < result.Length; i++)
                result[i] = func();
            return result;
        }

        [Pure]
        public static IEnumerable<T> RepeatSeq<T, TSource>(TSource generator, Func<TSource, T> func, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            for (int i = 0; i < count; i++)
            {
                yield return func(generator);
            }
        }

        [Pure]
        public static IEnumerable<T> RepeatSeq<T>(Func<T> func, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            for (int i = 0; i < count; i++)
            {
                yield return func();
            }
        }
    }
}
