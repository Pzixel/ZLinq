﻿using System;
using System.Collections.Generic;
using ZLinq.Extension;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
        public static void WhereInPlace<T>(ref T[] source, Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            int i = 0;
            for (int j = 0; j < source.Length; j++)
            {
                T value = source[j];
                if (predicate(value) && i != j)
                {
                    source[i++] = source[j];
                }
            }
            Array.Resize(ref source, i);
        }

        public static void WhereInPlace<T>(this List<T> source, Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            int i = 0;
            for (int j = 0; j < source.Count; j++)
            {
                T value = source[j];
                if (predicate(value) && i != j)
                {
                    source[i++] = source[j];
                }
            }
            if (i == 0)
                source.Clear();
            else
                source.RemoveRange(i, source.Count - i);
        }

        public static void WhereInPlace<T>(this IList<T> source, Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            int i = 0;
            for (int j = 0; j < source.Count; j++)
            {
                T value = source[j];
                if (predicate(value) && i != j)
                {
                    source[i++] = source[j];
                }
            }
            if (i == 0)
                source.Clear();
            else
            {
                for (int j = source.Count - 1; j >= i; j--)
                {
                    source.RemoveAt(i);
                }
            }
        }
    }
}
