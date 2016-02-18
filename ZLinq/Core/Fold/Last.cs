using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        [Pure]
        public static T Last<T>([NotNull] this T[] source)
        {
			source.IsNotNull("source");
			int lengthOrCount = source.Length;
			if (lengthOrCount == 0)
			   throw Error.EmptyCollection;
            return source[lengthOrCount - 1];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure]
        public static T Last<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Length - 1; i >= 0; i--)
            {
                T obj = source[i];
                if (predicate(obj))
                    return obj;
            }
            throw Error.NoMatchingElement;
        }

                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements</exception>
        [Pure]
        public static T Last<T>([NotNull] this List<T> source)
        {
			source.IsNotNull("source");
			int lengthOrCount = source.Count;
			if (lengthOrCount == 0)
			   throw Error.EmptyCollection;
            return source[lengthOrCount - 1];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure]
        public static T Last<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Count - 1; i >= 0; i--)
            {
                T obj = source[i];
                if (predicate(obj))
                    return obj;
            }
            throw Error.NoMatchingElement;
        }

                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements</exception>
        [Pure]
        public static T Last<T>([NotNull] this IList<T> source)
        {
			source.IsNotNull("source");
			int lengthOrCount = source.Count;
			if (lengthOrCount == 0)
			   throw Error.EmptyCollection;
            return source[lengthOrCount - 1];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure]
        public static T Last<T>([NotNull] this IList<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Count - 1; i >= 0; i--)
            {
                T obj = source[i];
                if (predicate(obj))
                    return obj;
            }
            throw Error.NoMatchingElement;
        }

                
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements</exception>
        [Pure]
        public static T Last<T>([NotNull] this ICollection<T> source)
        {
            source.IsNotNull("source");
            if (source.Count == 0)
			   throw Error.EmptyCollection;
            return LastHasElements(source);
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
            if (!flag) throw Error.NoMatchingElement;
            return result;
        }

		             
			
			        
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T LastOrDefault<T>([NotNull] this T[] source)
        {
			source.IsNotNull("source");
			int lengthOrCount = source.Length;
			if (lengthOrCount == 0)
			   return default(T);
            return source[lengthOrCount - 1];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T LastOrDefault<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Length - 1; i >= 0; i--)
            {
                T obj = source[i];
                if (predicate(obj))
                    return obj;
            }
            return default(T);
        }

                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T LastOrDefault<T>([NotNull] this List<T> source)
        {
			source.IsNotNull("source");
			int lengthOrCount = source.Count;
			if (lengthOrCount == 0)
			   return default(T);
            return source[lengthOrCount - 1];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T LastOrDefault<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Count - 1; i >= 0; i--)
            {
                T obj = source[i];
                if (predicate(obj))
                    return obj;
            }
            return default(T);
        }

                
                   
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T LastOrDefault<T>([NotNull] this IList<T> source)
        {
			source.IsNotNull("source");
			int lengthOrCount = source.Count;
			if (lengthOrCount == 0)
			   return default(T);
            return source[lengthOrCount - 1];
        }        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T LastOrDefault<T>([NotNull] this IList<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull("source");
            predicate.IsNotNull("predicate");
            for (int i = source.Count - 1; i >= 0; i--)
            {
                T obj = source[i];
                if (predicate(obj))
                    return obj;
            }
            return default(T);
        }

                
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T LastOrDefault<T>([NotNull] this ICollection<T> source)
        {
            source.IsNotNull("source");
            if (source.Count == 0)
			   return default(T);
            return LastHasElements(source);
        }

		
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection is empty</exception>
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T LastOrDefault<T>([NotNull] this ICollection<T> source, [NotNull] Predicate<T> predicate)
        {
            var list = source as IList<T>;
            if (list != null)
            {
                return list.Last(predicate);
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

    }
}
