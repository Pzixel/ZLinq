using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using ZLinq.Extension;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static partial class ZEnumerable
    {             
                
                   
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
           public static T Single<T>([NotNull] this T[] source)
        {            
            if (source.Length > 1)
            {
                throw new InvalidOperationException("Collection contains more than one element");
            }
            return source[0];
        }     

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T SingleOrDefault<T>([NotNull] this T[] source)
        {            
            if (source.Length > 1)
            {
                throw new InvalidOperationException("Collection contains more than one element");
            }
            return source.Length == 0 ? default(T) :  source[0];
        }    
    
                
                   
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
           public static T Single<T>([NotNull] this List<T> source)
        {            
            if (source.Count > 1)
            {
                throw new InvalidOperationException("Collection contains more than one element");
            }
            return source[0];
        }     

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T SingleOrDefault<T>([NotNull] this List<T> source)
        {            
            if (source.Count > 1)
            {
                throw new InvalidOperationException("Collection contains more than one element");
            }
            return source.Count == 0 ? default(T) :  source[0];
        }    
    
                
                   
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
           public static T Single<T>([NotNull] this IList<T> source)
        {            
            if (source.Count > 1)
            {
                throw new InvalidOperationException("Collection contains more than one element");
            }
            return source[0];
        }     

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T SingleOrDefault<T>([NotNull] this IList<T> source)
        {            
            if (source.Count > 1)
            {
                throw new InvalidOperationException("Collection contains more than one element");
            }
            return source.Count == 0 ? default(T) :  source[0];
        }    
    
            
        [Pure]
        public static T Single<T>([NotNull] this ICollection<T> source)
        {
            var list = source as IList<T>;
            if (list != null)
            {
                return list.Single();
            }

            if (source.Count > 1)
            {
                throw new InvalidOperationException("Collection contains more than one element");
            }
            using (var enumerator = source.GetEnumerator())
            {
                enumerator.MoveNext();
                return enumerator.Current;
            }
        }

        [Pure]
        public static T SingleOrDefault<T>([NotNull] this ICollection<T> source)
        {
            var list = source as IList<T>;
            if (list != null)
            {
                return list.SingleOrDefault();
            }

            if (source.Count > 1)
            {
                throw new InvalidOperationException("Collection contains more than one element");
            }
            using (var enumerator = source.GetEnumerator())
            {
                enumerator.MoveNext();
                return enumerator.Current;
            }
        }
                

        [Pure]
        public static T Single<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw new InvalidOperationException("Collection contains more than one element");
                    result = value;    
                    found = true;
                }
            }
            if (!found)
                throw new InvalidOperationException("Collection has no elements");
            return result;
        }

        [Pure]
        public static T SingleOrDefault<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw new InvalidOperationException("Collection contains more than one element");
                    result = value;    
                    found = true;
                }
            }
            return result;
        }

                

        [Pure]
        public static T Single<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw new InvalidOperationException("Collection contains more than one element");
                    result = value;    
                    found = true;
                }
            }
            if (!found)
                throw new InvalidOperationException("Collection has no elements");
            return result;
        }

        [Pure]
        public static T SingleOrDefault<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw new InvalidOperationException("Collection contains more than one element");
                    result = value;    
                    found = true;
                }
            }
            return result;
        }

                

        [Pure]
        public static T Single<T>([NotNull] this IEnumerable<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw new InvalidOperationException("Collection contains more than one element");
                    result = value;    
                    found = true;
                }
            }
            if (!found)
                throw new InvalidOperationException("Collection has no elements");
            return result;
        }

        [Pure]
        public static T SingleOrDefault<T>([NotNull] this IEnumerable<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw new InvalidOperationException("Collection contains more than one element");
                    result = value;    
                    found = true;
                }
            }
            return result;
        }

                

    }
}
