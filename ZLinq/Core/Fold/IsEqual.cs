
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {   
                
        
        /// <summary>
        ///    Check if collections are equal 
        /// </summary>
        /// <typeparam name="T">IEquatable collection</typeparam>
        /// <param name="x">first collection</param>
        /// <param name="y">second collection</param>
        /// <returns>true if collections are equal</returns> 
        [Pure]
        public static bool IsEqual<T>(this T[] x, T[] y) where T : IEquatable<T> 
        {
            if (ReferenceEquals(x, y))
                return true;
            if (x == null || y == null)
                return false;
            int length = x.Length;
            if (length != y.Length)
                return false;
            int i;
            for (i = 0; i < length; i++) 
            {
                if (!x[i].Equals(y[i]))
                    return false;
            }
            return true;
        }

                    
        
        /// <summary>
        ///    Check if collections are equal 
        /// </summary>
        /// <typeparam name="T">IEquatable collection</typeparam>
        /// <param name="x">first collection</param>
        /// <param name="y">second collection</param>
        /// <returns>true if collections are equal</returns> 
        [Pure]
        public static bool IsEqual<T>(this List<T> x, List<T> y) where T : IEquatable<T> 
        {
            if (ReferenceEquals(x, y))
                return true;
            if (x == null || y == null)
                return false;
            int length = x.Count;
            if (length != y.Count)
                return false;
            int i;
            for (i = 0; i < length; i++) 
            {
                if (!x[i].Equals(y[i]))
                    return false;
            }
            return true;
        }

                    
        
        /// <summary>
        ///    Check if collections are equal 
        /// </summary>
        /// <typeparam name="T">IEquatable collection</typeparam>
        /// <param name="x">first collection</param>
        /// <param name="y">second collection</param>
        /// <returns>true if collections are equal</returns> 
        [Pure]
        public static bool IsEqual<T>(this IList<T> x, IList<T> y) where T : IEquatable<T> 
        {
            if (ReferenceEquals(x, y))
                return true;
            if (x == null || y == null)
                return false;
            int length = x.Count;
            if (length != y.Count)
                return false;
            int i;
            for (i = 0; i < length; i++) 
            {
                if (!x[i].Equals(y[i]))
                    return false;
            }
            return true;
        }

                    

        /// <summary>
        ///    Check if collections are equal 
        /// </summary>
        /// <typeparam name="T">IEquatable collection</typeparam>
        /// <param name="x">first collection</param>
        /// <param name="y">second collection</param>
        /// <returns>true if collections are equal</returns> 
        [Pure]
        public static bool IsEqual<T>(this ICollection<T> x, ICollection<T> y) where T : IEquatable<T> 
        {
            if (ReferenceEquals(x, y))
                return true;
            if (x == null || y == null)
                return false;
            int length = x.Count;
            if (length != y.Count)
                return false;
            bool result = true;
            IEnumerator<T> xEnum = x.GetEnumerator(), yEnum = y.GetEnumerator();
            while(xEnum.MoveNext() && yEnum.MoveNext())
            {
                if (!xEnum.Current.Equals(yEnum.Current))
                {
                    result = false;
                    break;
                }
            }
            xEnum.Dispose();
            yEnum.Dispose();
            return result;
        }
                
        
        /// <summary>
        ///    Check if collections are equal. Use Object.Equals for equality comparasion 
        /// </summary>
        /// <typeparam name="T">IEquatable collection</typeparam>
        /// <param name="x">first collection</param>
        /// <param name="y">second collection</param>
        /// <returns>true if collections are equal</returns> 
        [Pure]
        public static bool IsEqualMemberwise<T>(this T[] x, T[] y)  
        {
            if (ReferenceEquals(x, y))
                return true;
            if (x == null || y == null)
                return false;
            int length = x.Length;
            if (length != y.Length)
                return false;
            int i;
            for (i = 0; i < length; i++) 
            {
                if (!x[i].Equals(y[i]))
                    return false;
            }
            return true;
        }

                    
        
        /// <summary>
        ///    Check if collections are equal. Use Object.Equals for equality comparasion 
        /// </summary>
        /// <typeparam name="T">IEquatable collection</typeparam>
        /// <param name="x">first collection</param>
        /// <param name="y">second collection</param>
        /// <returns>true if collections are equal</returns> 
        [Pure]
        public static bool IsEqualMemberwise<T>(this List<T> x, List<T> y)  
        {
            if (ReferenceEquals(x, y))
                return true;
            if (x == null || y == null)
                return false;
            int length = x.Count;
            if (length != y.Count)
                return false;
            int i;
            for (i = 0; i < length; i++) 
            {
                if (!x[i].Equals(y[i]))
                    return false;
            }
            return true;
        }

                    
        
        /// <summary>
        ///    Check if collections are equal. Use Object.Equals for equality comparasion 
        /// </summary>
        /// <typeparam name="T">IEquatable collection</typeparam>
        /// <param name="x">first collection</param>
        /// <param name="y">second collection</param>
        /// <returns>true if collections are equal</returns> 
        [Pure]
        public static bool IsEqualMemberwise<T>(this IList<T> x, IList<T> y)  
        {
            if (ReferenceEquals(x, y))
                return true;
            if (x == null || y == null)
                return false;
            int length = x.Count;
            if (length != y.Count)
                return false;
            int i;
            for (i = 0; i < length; i++) 
            {
                if (!x[i].Equals(y[i]))
                    return false;
            }
            return true;
        }

                    

        /// <summary>
        ///    Check if collections are equal. Use Object.Equals for equality comparasion 
        /// </summary>
        /// <typeparam name="T">IEquatable collection</typeparam>
        /// <param name="x">first collection</param>
        /// <param name="y">second collection</param>
        /// <returns>true if collections are equal</returns> 
        [Pure]
        public static bool IsEqualMemberwise<T>(this ICollection<T> x, ICollection<T> y)  
        {
            if (ReferenceEquals(x, y))
                return true;
            if (x == null || y == null)
                return false;
            int length = x.Count;
            if (length != y.Count)
                return false;
            bool result = true;
            IEnumerator<T> xEnum = x.GetEnumerator(), yEnum = y.GetEnumerator();
            while(xEnum.MoveNext() && yEnum.MoveNext())
            {
                if (!xEnum.Current.Equals(yEnum.Current))
                {
                    result = false;
                    break;
                }
            }
            xEnum.Dispose();
            yEnum.Dispose();
            return result;
        }
            
    }
}
