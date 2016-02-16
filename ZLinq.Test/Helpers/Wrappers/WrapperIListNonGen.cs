using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZLinq.Test.Helpers.Wrappers
{
    class WrapperIListNonGen<T> : IList
    {
        private readonly IList _collection;

        public WrapperIListNonGen(IEnumerable<T> collection)
        {
            _collection = collection.ToList();
        }

        public IEnumerator GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            _collection.CopyTo(array, index);
        }

        public int Count
        {
            get { return _collection.Count; }
        }

        public object SyncRoot
        {
            get { return _collection.SyncRoot; }
        }

        public bool IsSynchronized
        {
            get { return _collection.IsSynchronized; }
        }

        public int Add(object value)
        {
            return _collection.Add(value);
        }

        public bool Contains(object value)
        {
            return _collection.Contains(value);
        }

        public void Clear()
        {
            _collection.Clear();
        }

        public int IndexOf(object value)
        {
            return _collection.IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            _collection.Insert(index, value);
        }

        public void Remove(object value)
        {
            _collection.Remove(value);
        }

        public void RemoveAt(int index)
        {
            _collection.RemoveAt(index);
        }

        public object this[int index]
        {
            get { return _collection[index]; }
            set { _collection[index] = value; }
        }

        public bool IsReadOnly
        {
            get { return _collection.IsReadOnly; }
        }

        public bool IsFixedSize
        {
            get { return _collection.IsFixedSize; }
        }
    }
}