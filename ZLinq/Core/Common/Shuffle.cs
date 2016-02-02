
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using ZLinq.Extension;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {                    
                

        /// <summary>
        /// Fisher-Yates algorithm
        /// </summary>    
        public static void Shuffle<T>([NotNull] this T[] source, int? seed = null)
        {
            source.IsNotNull("source");

            if (source.Length == 0)
                return;
            int value = seed ?? Environment.TickCount ^ source[0].GetHashCode();
            Random rand = new Random(value);
            for (int i = source.Length - 1; i > 0; i--) {
                int j = rand.Next(0, i + 1);
                T tmp = source[i];
                source[i] = source[j];
                source[j] = tmp;
            }
        }

        [System.Diagnostics.Contracts.Pure]
        [NotNull]
        public static T[] GetShuffle<T>([NotNull] this T[] source, int? seed = null)
        {
            source.IsNotNull("source");

            T[] result = new T[source.Length];
            source.CopyTo(result, 0);
            result.Shuffle(seed);
            return result;
        }
                

        /// <summary>
        /// Fisher-Yates algorithm
        /// </summary>    
        public static void Shuffle<T>([NotNull] this List<T> source, int? seed = null)
        {
            source.IsNotNull("source");

            if (source.Count == 0)
                return;
            int value = seed ?? Environment.TickCount ^ source[0].GetHashCode();
            Random rand = new Random(value);
            for (int i = source.Count - 1; i > 0; i--) {
                int j = rand.Next(0, i + 1);
                T tmp = source[i];
                source[i] = source[j];
                source[j] = tmp;
            }
        }

        [System.Diagnostics.Contracts.Pure]
        [NotNull]
        public static T[] GetShuffle<T>([NotNull] this List<T> source, int? seed = null)
        {
            source.IsNotNull("source");

            T[] result = new T[source.Count];
            source.CopyTo(result, 0);
            result.Shuffle(seed);
            return result;
        }
                

        /// <summary>
        /// Fisher-Yates algorithm
        /// </summary>    
        public static void Shuffle<T>([NotNull] this IList<T> source, int? seed = null)
        {
            source.IsNotNull("source");

            if (source.Count == 0)
                return;
            int value = seed ?? Environment.TickCount ^ source[0].GetHashCode();
            Random rand = new Random(value);
            for (int i = source.Count - 1; i > 0; i--) {
                int j = rand.Next(0, i + 1);
                T tmp = source[i];
                source[i] = source[j];
                source[j] = tmp;
            }
        }

        [System.Diagnostics.Contracts.Pure]
        [NotNull]
        public static T[] GetShuffle<T>([NotNull] this IList<T> source, int? seed = null)
        {
            source.IsNotNull("source");

            T[] result = new T[source.Count];
            source.CopyTo(result, 0);
            result.Shuffle(seed);
            return result;
        }
                
    }
}
