using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZLinq.Test.Helpers.Wrappers
{
    class WrapperICollection<T> : ICollection<T>
    {
        private readonly ICollection<T> _collection;

        public WrapperICollection(IEnumerable<T> collection)
        {
            _collection = collection.ToList();
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return _collection.GetEnumerator();
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _collection).GetEnumerator();
        }
    }
}