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
	   	public static T Single<T>(this T[] source)
        {		    
			if (source.Length > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source[0];
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
	   	public static T Single<T>(this List<T> source)
        {		    
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source[0];
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
	   	public static T Single<T>(this IList<T> source)
        {		    
			if (source.Count > 1)
		    {
                throw new InvalidOperationException("Collection contains more than one element");
            }
			return source[0];
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
	
			
		
				

		[Pure]
		public static T Single<T>(this T[] source, Predicate<T> predicate)
        {
			T result = default(T);
			bool found = false;
		    foreach (T value in source)
		    {
		        if (predicate(value))
		        {
					if (found)
						throw new InvalidOperationException("Collection contains more than one element");
					result = value;	
					found = true;
				}
		    }
			if (!found)
				throw new InvalidOperationException("Collection has no elements");
			return result;
        }

		[Pure]
		public static T SingleOrDefault<T>(this T[] source, Predicate<T> predicate)
        {
			T result = default(T);
			bool found = false;
		    foreach (T value in source)
		    {
		        if (predicate(value))
		        {
					if (found)
						throw new InvalidOperationException("Collection contains more than one element");
					result = value;	
					found = true;
				}
		    }
			return result;
        }

				

		[Pure]
		public static T Single<T>(this List<T> source, Predicate<T> predicate)
        {
			T result = default(T);
			bool found = false;
		    foreach (T value in source)
		    {
		        if (predicate(value))
		        {
					if (found)
						throw new InvalidOperationException("Collection contains more than one element");
					result = value;	
					found = true;
				}
		    }
			if (!found)
				throw new InvalidOperationException("Collection has no elements");
			return result;
        }

		[Pure]
		public static T SingleOrDefault<T>(this List<T> source, Predicate<T> predicate)
        {
			T result = default(T);
			bool found = false;
		    foreach (T value in source)
		    {
		        if (predicate(value))
		        {
					if (found)
						throw new InvalidOperationException("Collection contains more than one element");
					result = value;	
					found = true;
				}
		    }
			return result;
        }

				

		[Pure]
		public static T Single<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
			T result = default(T);
			bool found = false;
		    foreach (T value in source)
		    {
		        if (predicate(value))
		        {
					if (found)
						throw new InvalidOperationException("Collection contains more than one element");
					result = value;	
					found = true;
				}
		    }
			if (!found)
				throw new InvalidOperationException("Collection has no elements");
			return result;
        }

		[Pure]
		public static T SingleOrDefault<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
			T result = default(T);
			bool found = false;
		    foreach (T value in source)
		    {
		        if (predicate(value))
		        {
					if (found)
						throw new InvalidOperationException("Collection contains more than one element");
					result = value;	
					found = true;
				}
		    }
			return result;
        }

				

    }
}
