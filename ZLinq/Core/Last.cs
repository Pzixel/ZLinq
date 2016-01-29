using System;
using System.Collections;
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
		public static TResult Last<T, TResult>(this T[] source, Func<T, TResult> func)
        {
			return func(source[source.Length - 1]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T LastOrDefault<T>(this T[] source)
        {
			return source.Length == 0 ? default(T) :  source[source.Length - 1];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult LastOrDefault<T, TResult>(this T[] source, Func<T, TResult> func)
        {
			return source.Length == 0 ? default(TResult) : func(source[source.Length - 1]);
        }
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T Last<T>(this List<T> source)
        {
			return source[source.Count - 1];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult Last<T, TResult>(this List<T> source, Func<T, TResult> func)
        {
			return func(source[source.Count - 1]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T LastOrDefault<T>(this List<T> source)
        {
			return source.Count == 0 ? default(T) :  source[source.Count - 1];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult LastOrDefault<T, TResult>(this List<T> source, Func<T, TResult> func)
        {
			return source.Count == 0 ? default(TResult) : func(source[source.Count - 1]);
        }
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T Last<T>(this IList<T> source)
        {
			return source[source.Count - 1];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult Last<T, TResult>(this IList<T> source, Func<T, TResult> func)
        {
			return func(source[source.Count - 1]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T LastOrDefault<T>(this IList<T> source)
        {
			return source.Count == 0 ? default(T) :  source[source.Count - 1];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult LastOrDefault<T, TResult>(this IList<T> source, Func<T, TResult> func)
        {
			return source.Count == 0 ? default(TResult) : func(source[source.Count - 1]);
        }
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T Last<T>(this IList source)
        {
			return (T)source[source.Count - 1];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult Last<T, TResult>(this IList source, Func<T, TResult> func)
        {
			return func((T)source[source.Count - 1]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T LastOrDefault<T>(this IList source)
        {
			return source.Count == 0 ? default(T) : (T) source[source.Count - 1];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult LastOrDefault<T, TResult>(this IList source, Func<T, TResult> func)
        {
			return source.Count == 0 ? default(TResult) : func((T)source[source.Count - 1]);
        }
				

    }
}
