using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZLinq.Test.Helpers.Wrappers
{
    class WrapperICollectionNonGen<T> : ICollection
    {
        private readonly ICollection _collection;

        public WrapperICollectionNonGen(IEnumerable<T> collection)
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
    }
}