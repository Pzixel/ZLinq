using System.Collections;
using System.Collections.Generic;

namespace ZLinq.Test.Helpers.Wrappers
{
    public sealed class WrapperIEnumerable<T> : IEnumerable<T>
    {
        private readonly IEnumerable<T> _enumerable;

        public WrapperIEnumerable(IEnumerable<T> enumerable)
        {
            _enumerable = enumerable;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var value in _enumerable)
                yield return value;
        }
    }
}
