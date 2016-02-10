using ZLinq.Comparers;

namespace ZLinq.Class
{
    public interface IZOrderedEnumerable<T>
    {
        ZComparer<T> Comparer { get; }
        IZOrderedEnumerable<T> AppendComparer(ZComparer<T> comparer);
        void Sort();
    }
}
