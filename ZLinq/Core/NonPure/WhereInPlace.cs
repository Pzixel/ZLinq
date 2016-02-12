using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using ZLinq.Common;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
        public static void WhereInPlace<T>([NotNull] ref T[] source, [NotNull] Predicate<T> predicate)
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

        public static void WhereInPlace<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
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

        public static void WhereInPlace<T>([NotNull] this IList<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            if (source is T[])
            {
                throw new NotSupportedException("Arrays should be processed with ref overload because of resizing. It couldn't be done by interface reference");
            }
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
