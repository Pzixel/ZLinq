using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {     		
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T Last<T>(this T[] source)
        {
			return source[source.Length - 1];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T LastOrDefault<T>(this T[] source)
        {
			return source.Length == 0 ? default(T) :  source[source.Length - 1];
        }	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Last<T>(this T[] source, Predicate<T> predicate)
		{
			for (int i = source.Length - 1; i >= 0; i--)
			{
				T obj =  source[i];
				if (predicate(obj))
					return obj;
			}
			throw new InvalidOperationException();
		}

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T LastOrDefault<T>(this T[] source, Predicate<T> predicate)
		{
			for (int i = source.Length - 1; i >= 0; i--)
			{
				T obj =  source[i];
				if (predicate(obj))
					return obj;
			}
			return default(T);
		}
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T Last<T>(this List<T> source)
        {
			return source[source.Count - 1];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T LastOrDefault<T>(this List<T> source)
        {
			return source.Count == 0 ? default(T) :  source[source.Count - 1];
        }	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Last<T>(this List<T> source, Predicate<T> predicate)
		{
			for (int i = source.Count - 1; i >= 0; i--)
			{
				T obj =  source[i];
				if (predicate(obj))
					return obj;
			}
			throw new InvalidOperationException();
		}

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T LastOrDefault<T>(this List<T> source, Predicate<T> predicate)
		{
			for (int i = source.Count - 1; i >= 0; i--)
			{
				T obj =  source[i];
				if (predicate(obj))
					return obj;
			}
			return default(T);
		}
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T Last<T>(this IList<T> source)
        {
			return source[source.Count - 1];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T LastOrDefault<T>(this IList<T> source)
        {
			return source.Count == 0 ? default(T) :  source[source.Count - 1];
        }	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Last<T>(this IList<T> source, Predicate<T> predicate)
		{
			for (int i = source.Count - 1; i >= 0; i--)
			{
				T obj =  source[i];
				if (predicate(obj))
					return obj;
			}
			throw new InvalidOperationException();
		}

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T LastOrDefault<T>(this IList<T> source, Predicate<T> predicate)
		{
			for (int i = source.Count - 1; i >= 0; i--)
			{
				T obj =  source[i];
				if (predicate(obj))
					return obj;
			}
			return default(T);
		}
				

    }
}
