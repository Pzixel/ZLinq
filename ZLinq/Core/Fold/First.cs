using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using JetBrains.Annotations;
using ZLinq.CommonInternal;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
				
						        
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements</exception>
        [Pure]
        public static T First<T>([NotNull, Pure] this T[] source)
        {
			source.IsNotNull(nameof(source));
			int lengthOrCount = source.Length;
			if (lengthOrCount == 0)
			   throw Error.EmptyCollection;
            return source[0];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure]
        public static T First<T>([NotNull, Pure] this T[] source, [NotNull, Pure] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            throw Error.NoMatchingElement;
        }

                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements</exception>
        [Pure]
        public static T First<T>([NotNull, Pure] this List<T> source)
        {
			source.IsNotNull(nameof(source));
			int lengthOrCount = source.Count;
			if (lengthOrCount == 0)
			   throw Error.EmptyCollection;
            return source[0];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure]
        public static T First<T>([NotNull, Pure] this List<T> source, [NotNull, Pure] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            throw Error.NoMatchingElement;
        }

                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements</exception>
        [Pure]
        public static T First<T>([NotNull, Pure] this IList<T> source)
        {
			source.IsNotNull(nameof(source));
			int lengthOrCount = source.Count;
			if (lengthOrCount == 0)
			   throw Error.EmptyCollection;
            return source[0];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure]
        public static T First<T>([NotNull, Pure] this IList<T> source, [NotNull, Pure] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            throw Error.NoMatchingElement;
        }

                
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements</exception>
        [Pure]
        public static T First<T>([NotNull, Pure] this ICollection<T> source)
        {
            source.IsNotNull(nameof(source));
            if (source.Count == 0)
			   throw Error.EmptyCollection;
            using (var enumerator = source.GetEnumerator())
            {
                enumerator.MoveNext();
                return enumerator.Current;
            }
        }
		
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure]
        public static T First<T>([NotNull, Pure] this ICollection<T> source, [NotNull, Pure] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            foreach (var value in source)
            {
                if (predicate(value))
                {
                    return value;
                }
            }
            throw Error.NoMatchingElement;
        }

					        
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T FirstOrDefault<T>([NotNull, Pure] this T[] source)
        {
			source.IsNotNull(nameof(source));
			int lengthOrCount = source.Length;
			if (lengthOrCount == 0)
			   return default(T);
            return source[0];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T FirstOrDefault<T>([NotNull, Pure] this T[] source, [NotNull, Pure] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            return default(T);
        }

                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T FirstOrDefault<T>([NotNull, Pure] this List<T> source)
        {
			source.IsNotNull(nameof(source));
			int lengthOrCount = source.Count;
			if (lengthOrCount == 0)
			   return default(T);
            return source[0];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T FirstOrDefault<T>([NotNull, Pure] this List<T> source, [NotNull, Pure] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            return default(T);
        }

                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T FirstOrDefault<T>([NotNull, Pure] this IList<T> source)
        {
			source.IsNotNull(nameof(source));
			int lengthOrCount = source.Count;
			if (lengthOrCount == 0)
			   return default(T);
            return source[0];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T FirstOrDefault<T>([NotNull, Pure] this IList<T> source, [NotNull, Pure] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            foreach (T value in source)
            {
                if (predicate(value))
                    return value;
            }
            return default(T);
        }

                
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T FirstOrDefault<T>([NotNull, Pure] this ICollection<T> source)
        {
            source.IsNotNull(nameof(source));
            if (source.Count == 0)
			   return default(T);
            using (var enumerator = source.GetEnumerator())
            {
                enumerator.MoveNext();
                return enumerator.Current;
            }
        }
		
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T FirstOrDefault<T>([NotNull, Pure] this ICollection<T> source, [NotNull, Pure] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            foreach (var value in source)
            {
                if (predicate(value))
                {
                    return value;
                }
            }
            return default(T);
        }

				
    }
}
