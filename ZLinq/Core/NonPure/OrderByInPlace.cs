using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using JetBrains.Annotations;
using ZLinq.Class;
using ZLinq.Comparers;
using ZLinq.Common;

// ReSharper disable CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
            
        [Pure]
        [NotNull]
        public static IZOrderedEnumerable<T> OrderByInPlace<T, TProperty>([NotNull] this T[] source, [NotNull] Expression<Func<T, TProperty>> member) where TProperty : IComparable<TProperty>
        {
            source.IsNotNull("source");
            member.IsNotNull("member");
            return new ZOrderedArray<T>(source, ZComparer<T>.New(member));
        }

        
        [Pure]
        [NotNull]
        public static IZOrderedEnumerable<T> OrderByInPlace<T, TProperty>([NotNull] this List<T> source, [NotNull] Expression<Func<T, TProperty>> member) where TProperty : IComparable<TProperty>
        {
            source.IsNotNull("source");
            member.IsNotNull("member");
            return new ZOrderedList<T>(source, ZComparer<T>.New(member));
        }

        
        [Pure]
        [NotNull]
        public static IZOrderedEnumerable<T> ThenBy<T, TProperty>([NotNull] this IZOrderedEnumerable<T> source, Expression<Func<T, TProperty>> member) where TProperty : IComparable<TProperty>
        {
            source.IsNotNull("source");
            member.IsNotNull("member");
            return source.AppendComparer(source.Comparer.Add(member));
        }
           
        [Pure]
        [NotNull]
        public static IZOrderedEnumerable<T> OrderByInPlaceDescending<T, TProperty>([NotNull] this T[] source, [NotNull] Expression<Func<T, TProperty>> member) where TProperty : IComparable<TProperty>
        {
            source.IsNotNull("source");
            member.IsNotNull("member");
            return new ZOrderedArray<T>(source, ZComparer<T>.NewNeg(member));
        }

        
        [Pure]
        [NotNull]
        public static IZOrderedEnumerable<T> OrderByInPlaceDescending<T, TProperty>([NotNull] this List<T> source, [NotNull] Expression<Func<T, TProperty>> member) where TProperty : IComparable<TProperty>
        {
            source.IsNotNull("source");
            member.IsNotNull("member");
            return new ZOrderedList<T>(source, ZComparer<T>.NewNeg(member));
        }

        
        [Pure]
        [NotNull]
        public static IZOrderedEnumerable<T> ThenByDescending<T, TProperty>([NotNull] this IZOrderedEnumerable<T> source, Expression<Func<T, TProperty>> member) where TProperty : IComparable<TProperty>
        {
            source.IsNotNull("source");
            member.IsNotNull("member");
            return source.AppendComparer(source.Comparer.AddNeg(member));
        }
       }
}
