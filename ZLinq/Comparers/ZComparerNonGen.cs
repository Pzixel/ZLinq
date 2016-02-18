using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using JetBrains.Annotations;

namespace ZLinq.Comparers
{
    [SuppressMessage("ReSharper", "StaticMemberInGenericType")]
    public static class ZComparer
    {
        [Pure]
        public static ZComparer<T> ForObject<T, TProperty>(T obj, [NotNull] Expression<Func<T, TProperty>> member, bool negate = false)
            where TProperty : IComparable<TProperty>
        {
            return ZComparer<T>.New(member, negate);
        }

        [Pure]
        public static ZComparer<T> ForObjectNeg<T, TProperty>(T obj, [NotNull] Expression<Func<T, TProperty>> member)
            where TProperty : IComparable<TProperty>
        {
            return ForObject(obj, member, true);
        }
    }
}