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
	   	public static T First<T>(this T[] source)
        {
			return source[0];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult First<T, TResult>(this T[] source, Func<T, TResult> func)
        {
			return func(source[0]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T FirstOrDefault<T>(this T[] source)
        {
			return source.Length == 0 ? default(T) :  source[0];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult FirstOrDefault<T, TResult>(this T[] source, Func<T, TResult> func)
        {
			return source.Length == 0 ? default(TResult) : func(source[0]);
        }
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T First<T>(this List<T> source)
        {
			return source[0];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult First<T, TResult>(this List<T> source, Func<T, TResult> func)
        {
			return func(source[0]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T FirstOrDefault<T>(this List<T> source)
        {
			return source.Count == 0 ? default(T) :  source[0];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult FirstOrDefault<T, TResult>(this List<T> source, Func<T, TResult> func)
        {
			return source.Count == 0 ? default(TResult) : func(source[0]);
        }
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T First<T>(this IList<T> source)
        {
			return source[0];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult First<T, TResult>(this IList<T> source, Func<T, TResult> func)
        {
			return func(source[0]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T FirstOrDefault<T>(this IList<T> source)
        {
			return source.Count == 0 ? default(T) :  source[0];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult FirstOrDefault<T, TResult>(this IList<T> source, Func<T, TResult> func)
        {
			return source.Count == 0 ? default(TResult) : func(source[0]);
        }
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T First<T>(this IList source)
        {
			return (T)source[0];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult First<T, TResult>(this IList source, Func<T, TResult> func)
        {
			return func((T)source[0]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T FirstOrDefault<T>(this IList source)
        {
			return source.Count == 0 ? default(T) : (T) source[0];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult FirstOrDefault<T, TResult>(this IList source, Func<T, TResult> func)
        {
			return source.Count == 0 ? default(TResult) : func((T)source[0]);
        }
				

    }
}
