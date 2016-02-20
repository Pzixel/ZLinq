using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace ZLinq.CommonInternal
{
    internal static class Guard
    {
        public static void IsNotNull<T>([Pure] this  T obj, string argName) where T : class
        {
            if (obj != null)
                return;
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