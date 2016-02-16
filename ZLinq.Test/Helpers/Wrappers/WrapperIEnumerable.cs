using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZLinq.Test.Helpers.Wrappers
{
    public sealed class WrapperIEnumerable<T> : IEnumerable<T>
    {
        private readonly IEnumerable<T> _collection;

        public WrapperIEnumerable(IEnumerable<T> collection)
        {
            _collection = collection.ToList();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public IEnumerator<T> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }
    }
}
