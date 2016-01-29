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
	   	public static T Single<T>(this T[] source)
        {		    
			if (source.Length > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source[0];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult Single<T, TResult>(this T[] source, Func<T, TResult> func)
        {			
			if (source.Length > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return func(source[0]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T SingleOrDefault<T>(this T[] source)
        {			
			if (source.Length > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source.Length == 0 ? default(T) :  source[0];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult SingleOrDefault<T, TResult>(this T[] source, Func<T, TResult> func)
        {			
			if (source.Length > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source.Length == 0 ? default(TResult) : func(source[0]);
        }
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T Single<T>(this List<T> source)
        {		    
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source[0];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult Single<T, TResult>(this List<T> source, Func<T, TResult> func)
        {			
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return func(source[0]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T SingleOrDefault<T>(this List<T> source)
        {			
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source.Count == 0 ? default(T) :  source[0];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult SingleOrDefault<T, TResult>(this List<T> source, Func<T, TResult> func)
        {			
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source.Count == 0 ? default(TResult) : func(source[0]);
        }
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T Single<T>(this IList<T> source)
        {		    
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source[0];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult Single<T, TResult>(this IList<T> source, Func<T, TResult> func)
        {			
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return func(source[0]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T SingleOrDefault<T>(this IList<T> source)
        {			
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source.Count == 0 ? default(T) :  source[0];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult SingleOrDefault<T, TResult>(this IList<T> source, Func<T, TResult> func)
        {			
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source.Count == 0 ? default(TResult) : func(source[0]);
        }
				
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	   	public static T Single<T>(this IList source)
        {		    
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return (T)source[0];
        }	 	

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult Single<T, TResult>(this IList source, Func<T, TResult> func)
        {			
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return func((T)source[0]);
        }

		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T SingleOrDefault<T>(this IList source)
        {			
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source.Count == 0 ? default(T) : (T) source[0];
        }		
		   	    
		[Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static TResult SingleOrDefault<T, TResult>(this IList source, Func<T, TResult> func)
        {			
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source.Count == 0 ? default(TResult) : func((T)source[0]);
        }
				

    }
}
