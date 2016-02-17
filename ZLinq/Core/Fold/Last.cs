using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using ZLinq.CommonInternal;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {             
                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T>([NotNull] this T[] source)
        {
			source.IsNotEmpty<T[], T>();
            return source[source.Length - 1];
        }         

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T LastOrDefault<T>([NotNull] this T[] source)
        {
            return source.Length == 0 ? default(T) :  source[source.Length - 1];
        }    

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Length - 1; i >= 0; i--)
            {
                T obj =  source[i];
                if (predicate(obj))
                    return obj;
            }
            throw new InvalidOperationException();
        }

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T LastOrDefault<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Length - 1; i >= 0; i--)
            {
                T obj =  source[i];
                if (predicate(obj))
                    return obj;
            }
            return default(T);
        }
                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T>([NotNull] this List<T> source)
        {
			source.IsNotEmpty<List<T>, T>();
            return source[source.Count - 1];
        }         

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T LastOrDefault<T>([NotNull] this List<T> source)
        {
            return source.Count == 0 ? default(T) :  source[source.Count - 1];
        }    

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Count - 1; i >= 0; i--)
            {
                T obj =  source[i];
                if (predicate(obj))
                    return obj;
            }
            throw new InvalidOperationException();
        }

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T LastOrDefault<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Count - 1; i >= 0; i--)
            {
                T obj =  source[i];
                if (predicate(obj))
                    return obj;
            }
            return default(T);
        }
                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T>([NotNull] this IList<T> source)
        {
			source.IsNotEmpty<IList<T>, T>();
            return source[source.Count - 1];
        }         

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T LastOrDefault<T>([NotNull] this IList<T> source)
        {
            return source.Count == 0 ? default(T) :  source[source.Count - 1];
        }    

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T>([NotNull] this IList<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Count - 1; i >= 0; i--)
            {
                T obj =  source[i];
                if (predicate(obj))
                    return obj;
            }
            throw new InvalidOperationException();
        }

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T LastOrDefault<T>([NotNull] this IList<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Count - 1; i >= 0; i--)
            {
                T obj =  source[i];
                if (predicate(obj))
                    return obj;
            }
            return default(T);
        }
                
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T>([NotNull] this ICollection<T> source)
        {
            source.IsNotNull("source");
            source.IsNotEmpty<ICollection<T>, T>();
            return LastHasElements(source);
        }

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T LastOrDefault<T>([NotNull] this ICollection<T> source)
        {
            source.IsNotNull("source");
            if (source.Count == 0)
                return default(T);
            return LastHasElements(source);
        }
        
        private static T LastHasElements<T>(ICollection<T> source)
        {
            var list = source as IList<T>;
            if (list != null)
            {
                return list.Last();
            }
            using (var enumerator = source.GetEnumerator())
            {
                enumerator.MoveNext();
                T current = enumerator.Current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                }
                return current;
            }
        }

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T>([NotNull] this ICollection<T> source, [NotNull] Predicate<T> predicate)
        {
            var list = source as IList<T>;
            if (list != null)
            {
                return list.Last(predicate);
            }

            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            T result = default(T);
            bool flag = false;
            foreach (var value in source)
            {
                if (predicate(value))
                {
                    result = value;
                    flag = true;
                }
            }
            if (flag)
                return result;
            throw new InvalidOperationException();
        }

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T LastOrDefault<T>([NotNull] this ICollection<T> source, [NotNull] Predicate<T> predicate)
        {
            var list = source as IList<T>;
            if (list != null)
            {
                return list.LastOrDefault(predicate);
            }

            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            T result = default(T);
            foreach (var value in source)
            {
                if (predicate(value))
                {
                    result = value;
                }
            }
            return result;
        }
    }
}
