using System.Collections.Generic;
using ZLinq.Comparers;

namespace ZLinq.Class
{
    internal class ZOrderedList<T> : IZOrderedEnumerable<T>
    {
        private readonly List<T> _source;
        public ZComparer<T> Comparer { get; }

        public ZOrderedList(List<T> source, ZComparer<T> comparer)
        {
            _source = source;
            Comparer = comparer;
        }
        
        public IZOrderedEnumerable<T> AppendComparer(ZComparer<T> comparer)
        {
            return new ZOrderedList<T>(_source, comparer);
        }

        public void Sort()
        {
            _source.Sort(Comparer.ToComparer());
        }
    }
}
