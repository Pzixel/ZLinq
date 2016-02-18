using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace ZLinq.CommonInternal
{
    internal static class Guard
    {
        public static void IsNotNull<T>([Pure] this  T obj, string argName = null) where T : class
        {
            if (obj != null)
                return;
            if (argName == null)
                throw new ArgumentNullException();
            throw new ArgumentNullException(argName);
        }

        public static void Requires<T>(bool condition) where T : Exception, new()
        {
            if (!condition)
                throw new T();
        }

        public static void IsNotEmpty<T>([Pure] this ICollection<T> collection)
        {
            if (collection.Count == 0)
                throw Error.EmptyCollection;
        }

        public static void HasSingleElement<T>(this ICollection<T> collection)
        {
            if (collection.Count > 1)
                throw Error.MultipleElementsCollection;
        }
    }
}