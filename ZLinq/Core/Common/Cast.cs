using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ZLinq.Class;
using ZLinq.CommonInternal;

// ReSharper disable once CheckNamespace
namespace ZLinq
{
    [SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static partial class ZEnumerable
    {
        public static IList<T> Cast<T>(this IList source)
        {
            source.IsNotNull(nameof(source));
            return CastInternal<T>(source);
        }

        private static IList<T> CastInternal<T>(IList source)
        {
            var ilist = source as IList<T>;
            if (ilist != null)
                return ilist;
            if (source.Count == 0)
                return new List<T>(0);
            if (!(source is Array))
                return new ListCaster<T>(source);
            var list = new List<T>(source.Count);
            foreach (T obj in source)
            {
                list.Add(obj);
            }
            return list;
        }

        public static IEnumerable<T> CastSeq<T>(this IEnumerable source)
        {
            source.IsNotNull(nameof(source));
            var ilist = source as IList;
            if (ilist != null)
            {
                return CastInternal<T>(ilist);
            }
            return CastSeqInternal<T>(source);
        }

        private static IEnumerable<T> CastSeqInternal<T>(IEnumerable source) // do not check inpus like Enumerable.Cast<T> due to performance reasons
        {
            foreach (T value in source)
            {
                yield return value;
            }
        }
    }
}
