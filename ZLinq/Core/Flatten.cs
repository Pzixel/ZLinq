using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using ZLinq.Extension;

// ReSharper disable LoopCanBeConvertedToQuery
// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
		[Pure]
		public static IEnumerable<T> Flatten<T>(this T[,] array)
        {
            foreach (T value in array)
                yield return value;
        }		

		[Pure]
		public static IEnumerable<T> Flatten<T>(this T[,,] array)
        {
            foreach (T value in array)
                yield return value;
        }		

		[Pure]
		public static IEnumerable<T> Flatten<T>(this T[,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }		

		[Pure]
		public static IEnumerable<T> Flatten<T>(this T[,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }		

		[Pure]
		public static IEnumerable<T> Flatten<T>(this T[,,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }		

		[Pure]
		public static IEnumerable<T> Flatten<T>(this T[,,,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }		

		[Pure]
		public static IEnumerable<T> Flatten<T>(this T[,,,,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }		

		[Pure]
		public static IEnumerable<T> Flatten<T>(this T[,,,,,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }		

		[Pure]
		public static IEnumerable<T> Flatten<T>(this T[,,,,,,,,,] array)
        {
            foreach (T value in array)
                yield return value;
        }		

		
		[Pure]
        public static T[] FlattenToArray<T>(this T[,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }	

		[Pure]
        public static T[] FlattenToArray<T>(this T[,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }	

		[Pure]
        public static T[] FlattenToArray<T>(this T[,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }	

		[Pure]
        public static T[] FlattenToArray<T>(this T[,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }	

		[Pure]
        public static T[] FlattenToArray<T>(this T[,,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }	

		[Pure]
        public static T[] FlattenToArray<T>(this T[,,,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }	

		[Pure]
        public static T[] FlattenToArray<T>(this T[,,,,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }	

		[Pure]
        public static T[] FlattenToArray<T>(this T[,,,,,,,,] array)
        {
            array.IsNotNull("array");
            var result = new T[array.Length];
            int i = 0;
            foreach (T value in array)
                result[i++] = value;
            return result;
        }	

		[Pure]
        public static T[] FlattenToArray<T>(this T[,,,,,,,,,] array)
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