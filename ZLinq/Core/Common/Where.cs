
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using ZLinq.Common;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    [SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
    public static partial class ZEnumerable
    {        
                    
        [Pure]
        public static T[] WhereToArray<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            var result = new T[source.Length];
            int i = 0;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    result[i++] = value;
                }
            }
            Array.Resize(ref result, i);
            return result;
        }

        [Pure]
        public static List<T> WhereToList<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            var result = new List<T>(source.Length);
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    result.Add(value);
                }
            }
            result.TrimExcess();
            return result;
        }
                    
        [Pure]
        public static T[] WhereToArray<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            var result = new T[source.Count];
            int i = 0;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    result[i++] = value;
                }
            }
            Array.Resize(ref result, i);
            return result;
        }

        [Pure]
        public static List<T> WhereToList<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            var result = new List<T>(source.Count);
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    result.Add(value);
                }
            }
            result.TrimExcess();
            return result;
        }
                    
        [Pure]
        public static T[] WhereToArray<T>([NotNull] this IList<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            var result = new T[source.Count];
            int i = 0;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    result[i++] = value;
                }
            }
            Array.Resize(ref result, i);
            return result;
        }

        [Pure]
        public static List<T> WhereToList<T>([NotNull] this IList<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            var result = new List<T>(source.Count);
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    result.Add(value);
                }
            }
            result.TrimExcess();
            return result;
        }
                    
        [Pure]
        public static T[] WhereToArray<T>([NotNull] this ICollection<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            var result = new T[source.Count];
            int i = 0;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    result[i++] = value;
                }
            }
            Array.Resize(ref result, i);
            return result;
        }

        [Pure]
        public static List<T> WhereToList<T>([NotNull] this ICollection<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            var result = new List<T>(source.Count);
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    result.Add(value);
                }
            }
            result.TrimExcess();
            return result;
        }
        
    }
}
