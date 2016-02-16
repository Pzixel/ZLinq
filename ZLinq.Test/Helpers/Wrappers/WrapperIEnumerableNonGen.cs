using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZLinq.Test.Helpers.Wrappers
{
    public sealed class WrapperIEnumerableNonGen<T> : IEnumerable
    {
        private readonly IEnumerable _collection;

        public WrapperIEnumerableNonGen(IEnumerable<T> collection)
        {
            _collection = collection.ToList();
        }

        public IEnumerator GetEnumerator()
        {
            return _collection.GetEnumerator();
        }
    }
}
