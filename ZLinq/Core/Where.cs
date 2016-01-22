
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using ZLinq.Extension;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {        
				    
		[Pure]
	    public static T[] WhereToArray<T>(this T[] source, Predicate<T> predicate)
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
	    public static List<T> WhereToList<T>(this T[] source, Predicate<T> predicate)
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
	    public static T[] WhereToArray<T>(this List<T> source, Predicate<T> predicate)
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
	    public static List<T> WhereToList<T>(this List<T> source, Predicate<T> predicate)
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
	    public static T[] WhereToArray<T>(this IList<T> source, Predicate<T> predicate)
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
	    public static List<T> WhereToList<T>(this IList<T> source, Predicate<T> predicate)
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
	    public static T[] WhereToArray<T>(this ICollection<T> source, Predicate<T> predicate)
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
	    public static List<T> WhereToList<T>(this ICollection<T> source, Predicate<T> predicate)
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
