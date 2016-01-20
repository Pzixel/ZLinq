using System;

namespace ZLinq.Extension
{
    internal static class Guard
    {
        public static void IsNotNull<T>(this T obj, string argName = null) where T : class
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
    }
}
