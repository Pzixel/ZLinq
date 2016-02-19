using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ZLinq.Class
{
    internal class ListCaster<T> : IList<T>
    {
        private readonly IList _source;

        public ListCaster(IList source)
        {
            _source = source;
        }

        [SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T value in _source)
            {
                yield return value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _source.GetEnumerator();
        }

        public void Add(T item)
        {
            _source.Add(item);
        }

        public void Clear()
        {
            _source.Clear();
        }

        public bool Contains(T item)
        {
            return _source.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _source.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index < 0)
                return false;
            RemoveAt(index);
            return true;
        }

        public int Count => _source.Count;
        public bool IsReadOnly => _source.IsReadOnly;

        public int IndexOf(T item)
        {
            return _source.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _source.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _source.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return (T) _source[index]; }
            set { _source[index] = value; }
        }
    }
}
