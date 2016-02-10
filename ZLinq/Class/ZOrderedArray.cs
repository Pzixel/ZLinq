using System;
using ZLinq.Comparers;

namespace ZLinq.Class
{
    internal class ZOrderedArray<T> : IZOrderedEnumerable<T>
    {
        private readonly T[] _source;
        public ZComparer<T> Comparer { get; }

        public ZOrderedArray(T[] source, ZComparer<T> comparer)
        {
            _source = source;
            Comparer = comparer;
        }
        
        public IZOrderedEnumerable<T> AppendComparer(ZComparer<T> comparer)
        {
            return new ZOrderedArray<T>(_source, comparer);
        }

        public void Sort()
        {
            Array.Sort(_source, Comparer.ToComparer());
        }
    }
}
