using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {     		
				
		   	    
		[Pure]
	    public static TResult FirstOrDefault<T, TResult>(this T[] source, Func<T, TResult> func)
        {
			return source.Length == 0 ? default(TResult) : func(source[0]);
        }	

		[Pure]
	    public static T FirstOrDefault<T>(this T[] source)
        {
			return source.Length == 0 ? default(T) :  source[0];
        }	
				
		   	    
		[Pure]
	    public static TResult FirstOrDefault<T, TResult>(this List<T> source, Func<T, TResult> func)
        {
			return source.Count == 0 ? default(TResult) : func(source[0]);
        }	

		[Pure]
	    public static T FirstOrDefault<T>(this List<T> source)
        {
			return source.Count == 0 ? default(T) :  source[0];
        }	
				
		   	    
		[Pure]
	    public static TResult FirstOrDefault<T, TResult>(this IList<T> source, Func<T, TResult> func)
        {
			return source.Count == 0 ? default(TResult) : func(source[0]);
        }	

		[Pure]
	    public static T FirstOrDefault<T>(this IList<T> source)
        {
			return source.Count == 0 ? default(T) :  source[0];
        }	
				
		   	    
		[Pure]
	    public static TResult FirstOrDefault<T, TResult>(this IList source, Func<T, TResult> func)
        {
			return source.Count == 0 ? default(TResult) : func((T)source[0]);
        }	

		[Pure]
	    public static T FirstOrDefault<T>(this IList source)
        {
			return source.Count == 0 ? default(T) : (T) source[0];
        }	
				

    }
}
