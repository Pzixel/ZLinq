using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ZLinq.CommonInternal;


// ReSharper disable CheckNamespace 
namespace ZLinq
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static partial class ZEnumerable
    {                   
          
  
		public static bool HasSeveralItems<T>(this T[] source, int count)
        {
            source.IsNotNull(nameof(source));
            return source.Length >= count;
        }
          
  
		public static bool HasSeveralItems<T>(this List<T> source, int count)
        {
            source.IsNotNull(nameof(source));
            return source.Count >= count;
        }
          
  
		public static bool HasSeveralItems<T>(this ICollection<T> source, int count)
        {
            source.IsNotNull(nameof(source));
            return source.Count >= count;
        }
        
        public static bool HasSeveralItems<T>(this IEnumerable<T> source, int count)
        {
            source.IsNotNull(nameof(source));
            if (count <= 0)
                return true;
            var collection = source as ICollection<T>;
            if (collection != null)
                return collection.HasSeveralItems(count);
            int i = count;
            using (var enumerator = source.GetEnumerator())
            {
                while (enumerator.MoveNext() && i > 0)
                {
					i--;
                }
            }
            return i == 0;
        }
    
	      
  
		public static bool HasSeveralItems<T>(this T[] source, int count, Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
			predicate.IsNotNull(nameof(predicate));
            int i = count;
            foreach (var value in source)
			{ 
			   if (predicate(value))
			   {
			      i--;
				  if (i == 0)
				     return true;
			   }
			}
            return false;
        }
          
  
		public static bool HasSeveralItems<T>(this List<T> source, int count, Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
			predicate.IsNotNull(nameof(predicate));
            int i = count;
            foreach (var value in source)
			{ 
			   if (predicate(value))
			   {
			      i--;
				  if (i == 0)
				     return true;
			   }
			}
            return false;
        }
          
  
		public static bool HasSeveralItems<T>(this IEnumerable<T> source, int count, Predicate<T> predicate)
        {
            source.IsNotNull(nameof(source));
			predicate.IsNotNull(nameof(predicate));
            int i = count;
            foreach (var value in source)
			{ 
			   if (predicate(value))
			   {
			      i--;
				  if (i == 0)
				     return true;
			   }
			}
            return false;
        }
        
    }
}
