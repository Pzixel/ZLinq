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
            var result = new T[count];
            for (int i = 0; i < result.Length; i++)
                result[i] = value;
            return result;
        }

        [Pure]
        public static T[] Repeat<T, TSource>(TSource generator, Func<TSource, T> func, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            var result = new T[count];
            for (int i = 0; i < result.Length; i++)
                result[i] = func(generator);
            return result;
        }

        [Pure]
        public static T[] Repeat<T>(Func<T> func, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            var result = new T[count];
            for (int i = 0; i < result.Length; i++)
                result[i] = func();
            return result;
        }

        
        [Pure]
        public static List<T> RepeatList<T>(T value, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            var result = new List<T>(count);
            for (int i = 0; i < count; i++)
                result.Add(value);
            return result;
        }

        [Pure]
        public static List<T> RepeatList<T, TSource>(TSource generator, Func<TSource, T> func, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            var result = new List<T>(count);
            for (int i = 0; i < count; i++)
                result.Add(func(generator));
            return result;
        }

        [Pure]
        public static List<T> RepeatList<T>(Func<T> func, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            var result = new List<T>(count);
            for (int i = 0; i < count; i++)
                result.Add(func());
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
