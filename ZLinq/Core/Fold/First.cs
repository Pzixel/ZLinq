using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using ZLinq.CommonInternal;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static partial class ZEnumerable
    {             
                
                   
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
           public static T First<T>([NotNull] this T[] source)
        {
            return source[0];
        }         

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T>([NotNull] this T[] source)
        {
            return source.Length == 0 ? default(T) : source[0];
        }        
                
                   
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
           public static T First<T>([NotNull] this List<T> source)
        {
            return source[0];
        }         

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T>([NotNull] this List<T> source)
        {
            return source.Count == 0 ? default(T) : source[0];
        }        
                
                   
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
           public static T First<T>([NotNull] this IList<T> source)
        {
            return source[0];
        }         

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T>([NotNull] this IList<T> source)
        {
            return source.Count == 0 ? default(T) : source[0];
        }        
                

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
           public static T First<T>([NotNull] this ICollection<T> source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Count == 0)
                throw new InvalidOperationException();
            var list = source as IList<T>;
            if (list != null)
            {
                return list.First();
            }
            using (var enumerator = source.GetEnumerator())
            {
                enumerator.MoveNext();
                return enumerator.Current;
            }
        }

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T>([NotNull] this ICollection<T> source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Count == 0)
                return default(T);
            var list = source as IList<T>;
            if (list != null)
            {
                return list.First();
            }
            using (var enumerator = source.GetEnumerator())
            {
                enumerator.MoveNext();
                return enumerator.Current;
            }
        }

                

        [Pure]
        public static T First<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            throw new InvalidOperationException();
        }
                   
        [Pure]
        public static T FirstOrDefault<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            return default(T);
        }
                

        [Pure]
        public static T First<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            throw new InvalidOperationException();
        }
                   
        [Pure]
        public static T FirstOrDefault<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            return default(T);
        }
                

        [Pure]
        public static T First<T>([NotNull] this IList<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            throw new InvalidOperationException();
        }
                   
        [Pure]
        public static T FirstOrDefault<T>([NotNull] this IList<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            return default(T);
        }
                

        [Pure]
        public static T First<T>([NotNull] this ICollection<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            throw new InvalidOperationException();
        }
                   
        [Pure]
        public static T FirstOrDefault<T>([NotNull] this ICollection<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            return default(T);
        }
                
    }
}
