using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZLinq.Test.Helpers.Wrappers
{
    class WrapperIList<T> : IList<T>
    {
        private readonly IList<T> _collection;

        public WrapperIList(IEnumerable<T> collection)
        {
            _collection = collection.ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _collection).GetEnumerator();
        }

        public void Add(T item)
        {
            _collection.Add(item);
        }

        public void Clear()
        {
            _collection.Clear();
        }

        public bool Contains(T item)
        {
            return _collection.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _collection.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _collection.Remove(item);
        }

        public int Count
        {
            get { return _collection.Count; }
        }

        public bool IsReadOnly
        {
            get { return _collection.IsReadOnly; }
        }

        public int IndexOf(T item)
        {
            return _collection.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _collection.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _collection.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return _collection[index]; }
            set { _collection[index] = value; }
        }
    }
}
