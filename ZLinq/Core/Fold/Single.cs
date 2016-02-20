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
        [Pure]
        public static T Single<T>([NotNull] this T[] source)
        {
			source.IsNotNull(nameof(source));            
            source.HasSingleElement();
			if (source.Length == 0)
			   throw Error.EmptyCollection;
            return source[0];
        }       
    
                
        
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>           
        [Pure]
        public static T Single<T>([NotNull] this List<T> source)
        {
			source.IsNotNull(nameof(source));            
            source.HasSingleElement();
			if (source.Count == 0)
			   throw Error.EmptyCollection;
            return source[0];
        }       
    
                
        
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>           
        [Pure]
        public static T Single<T>([NotNull] this IList<T> source)
        {
			source.IsNotNull(nameof(source));            
            source.HasSingleElement();
			if (source.Count == 0)
			   throw Error.EmptyCollection;
            return source[0];
        }       
    
            
		
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T Single<T>([NotNull] this ICollection<T> source)
        {
			source.IsNotNull(nameof(source));
            var list = source as IList<T>;
            if (list != null)
            {
                return list.Single();
            }

            source.HasSingleElement();
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
        public static T Single<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw Error.MultipleElementsCollection;
                    result = value;    
                    found = true;
                }
            }
            if (!found)
                throw Error.NoMatchingElement;
            return result;
        }		
		        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure]
        public static T Single<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw Error.MultipleElementsCollection;
                    result = value;    
                    found = true;
                }
            }
            if (!found)
                throw Error.NoMatchingElement;
            return result;
        }		
		        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure]
        public static T SingleSeq<T>([NotNull] this IEnumerable<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw Error.MultipleElementsCollection;
                    result = value;    
                    found = true;
                }
            }
            if (!found)
                throw Error.NoMatchingElement;
            return result;
        }		
		
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
		/// <exception cref="InvalidOperationException">Throws when collection has no elements matching the predicate</exception>
        [Pure]
		public static T Single<T>([NotNull] this ICollection<T> source, [NotNull] Predicate<T> predicate)
		{
		   return source.SingleSeq(predicate);
		}
                        
        
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>           
        [Pure]
        public static T SingleOrDefault<T>([NotNull] this T[] source)
        {
			source.IsNotNull(nameof(source));            
            source.HasSingleElement();
			if (source.Length == 0)
			   return default(T);
            return source[0];
        }       
    
                
        
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>           
        [Pure]
        public static T SingleOrDefault<T>([NotNull] this List<T> source)
        {
			source.IsNotNull(nameof(source));            
            source.HasSingleElement();
			if (source.Count == 0)
			   return default(T);
            return source[0];
        }       
    
                
        
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>           
        [Pure]
        public static T SingleOrDefault<T>([NotNull] this IList<T> source)
        {
			source.IsNotNull(nameof(source));            
            source.HasSingleElement();
			if (source.Count == 0)
			   return default(T);
            return source[0];
        }       
    
            
		
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T SingleOrDefault<T>([NotNull] this ICollection<T> source)
        {
			source.IsNotNull(nameof(source));
            var list = source as IList<T>;
            if (list != null)
            {
                return list.SingleOrDefault();
            }

            source.HasSingleElement();
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
        public static T SingleOrDefault<T>([NotNull] this T[] source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw Error.MultipleElementsCollection;
                    result = value;    
                    found = true;
                }
            }
            if (!found)
                return default(T);
            return result;
        }		
		        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T SingleOrDefault<T>([NotNull] this List<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw Error.MultipleElementsCollection;
                    result = value;    
                    found = true;
                }
            }
            if (!found)
                return default(T);
            return result;
        }		
		        

		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
        public static T SingleOrDefaultSeq<T>([NotNull] this IEnumerable<T> source, [NotNull] Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
            predicate.IsNotNull(nameof(predicate));
            T result = default(T);
            bool found = false;
            foreach (T value in source)
            {
                if (predicate(value))
                {
                    if (found)
                        throw Error.MultipleElementsCollection;
                    result = value;    
                    found = true;
                }
            }
            if (!found)
                return default(T);
            return result;
        }		
		
		/// <exception cref="ArgumentNullException">Throws when null is passed as input parameter</exception>
        [Pure]
		public static T SingleOrDefault<T>([NotNull] this ICollection<T> source, [NotNull] Predicate<T> predicate)
		{
		   return source.SingleOrDefaultSeq(predicate);
		}
                

    }
}
