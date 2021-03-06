﻿
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        [ContractAnnotation("source:null => true; source:notnull => false")]
        public static bool IsNullOrEmpty<T>([CanBeNull] this T[] source)
        {
            return source == null || source.Length == 0;
        }

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        [ContractAnnotation("source:null => true; source:notnull => false")]
        public static bool IsNullOrEmpty<T>([CanBeNull] this List<T> source)
        {
            return source == null || source.Count == 0;
        }

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        [ContractAnnotation("source:null => true; source:notnull => false")]
        public static bool IsNullOrEmpty<T>([CanBeNull] this IList<T> source)
        {
            return source == null || source.Count == 0;
        }

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        [ContractAnnotation("source:null => true; source:notnull => false")]
        public static bool IsNullOrEmpty<T>([CanBeNull] this ICollection<T> source)
        {
            return source == null || source.Count == 0;
        }

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        [ContractAnnotation("source:null => true; source:notnull => false")]
        public static bool IsNullOrEmpty([CanBeNull] this IList source)
        {
            return source == null || source.Count == 0;
        }

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        [ContractAnnotation("source:null => true; source:notnull => false")]
        public static bool IsNullOrEmpty([CanBeNull] this ICollection source)
        {
            return source == null || source.Count == 0;
        }

                [Pure]
        [ContractAnnotation("source:null => true; source:notnull => false")]
        public static bool IsNullOrEmpty<T>([CanBeNull] this IEnumerable<T> source)
        {
            if (source == null)
            {
               return true;
            }
            using (var enumerator = source.GetEnumerator())
            {
                if (enumerator.MoveNext())
                    return false;
            }
            return true;
        }

        [Pure]
        [ContractAnnotation("source:null => true; source:notnull => false")]
        public static bool IsNullOrEmpty([CanBeNull] this IEnumerable source)
        {
            if (source == null)
            {
                return true;
            }
            var enumerator = source.GetEnumerator();
            return !enumerator.MoveNext();
        }

        [System.Diagnostics.Contracts.Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        [ContractAnnotation("source:null => true; source:notnull => false")]
        public static bool IsNullOrEmpty([CanBeNull] this string source)
        {
            return string.IsNullOrEmpty(source);
        }
    }
}
