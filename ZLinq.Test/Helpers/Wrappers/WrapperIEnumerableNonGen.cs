using System.Collections;

namespace ZLinq.Test.Helpers.Wrappers
{
    public sealed class WrapperIEnumerableNonGen<T> : IEnumerable
    {
        private readonly IEnumerable _enumerable;

        public WrapperIEnumerableNonGen(IEnumerable enumerable)
        {
            _enumerable = enumerable;
        }

        public IEnumerator GetEnumerator()
        {
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var value in _enumerable)
                yield return value;
        }
    }
}
