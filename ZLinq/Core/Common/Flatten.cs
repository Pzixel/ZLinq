using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using ZLinq.Common;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    [SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
    public static partial class ZEnumerable
    {
        [Pure]
        [NotNull]
        public static IEnumerable<T> Flatten<T>([NotNull] this T[,] array)
        {
            foreach (T value in array)
                yield return value;
        }        

        [Pure]
        [NotNull]
        public static IEnumerable<T> Flatten<T>([NotNull] this T[,,] array)
        {
            foreach (T value in array)
                yield return value;
        }        

        [Pure]
        [NotNull]
        public static IEnumerable<T> Flatten<T>([NotNull] this T[,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }        

        [Pure]
        [NotNull]
        public static IEnumerable<T> Flatten<T>([NotNull] this T[,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }        

        [Pure]
        [NotNull]
        public static IEnumerable<T> Flatten<T>([NotNull] this T[,,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }        

        [Pure]
        [NotNull]
        public static IEnumerable<T> Flatten<T>([NotNull] this T[,,,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }        

        [Pure]
        [NotNull]
        public static IEnumerable<T> Flatten<T>([NotNull] this T[,,,,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }        

        [Pure]
        [NotNull]
        public static IEnumerable<T> Flatten<T>([NotNull] this T[,,,,,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }        

        [Pure]
        [NotNull]
        public static IEnumerable<T> Flatten<T>([NotNull] this T[,,,,,,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }        

        
        [Pure]
        [NotNull]
        public static T[] FlattenToArray<T>([NotNull] this T[,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }    

        [Pure]
        [NotNull]
        public static T[] FlattenToArray<T>([NotNull] this T[,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }    

        [Pure]
        [NotNull]
        public static T[] FlattenToArray<T>([NotNull] this T[,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }    

        [Pure]
        [NotNull]
        public static T[] FlattenToArray<T>([NotNull] this T[,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }    

        [Pure]
        [NotNull]
        public static T[] FlattenToArray<T>([NotNull] this T[,,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }    

        [Pure]
        [NotNull]
        public static T[] FlattenToArray<T>([NotNull] this T[,,,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }    

        [Pure]
        [NotNull]
        public static T[] FlattenToArray<T>([NotNull] this T[,,,,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }    

        [Pure]
        [NotNull]
        public static T[] FlattenToArray<T>([NotNull] this T[,,,,,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }    

        [Pure]
        [NotNull]
        public static T[] FlattenToArray<T>([NotNull] this T[,,,,,,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }    

        
    }
}