using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ZLinq.Class;
using ZLinq.CommonInternal;

// ReSharper disable once CheckNamespace
namespace ZLinq
{
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
            return new ListCaster<T>(source);
        }

        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
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

        [SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
        private static IEnumerable<T> CastSeqInternal<T>(IEnumerable source)
        {
            foreach (T value in source)
            {
                yield return value;
            }
        }
    }
}
