using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using JetBrains.Annotations;

namespace ZLinq.Comparers
{
    [SuppressMessage("ReSharper", "StaticMemberInGenericType")]
    public sealed class ZComparer<T>
    {
        #region private members
        private static readonly Dictionary<string, BlockExpression> MemberMemoizeDictionary = new Dictionary<string, BlockExpression>();
        private static readonly LabelTarget RetLabelTarget = Expression.Label(typeof(int));
        private static readonly ParameterExpression Result = Expression.Variable(typeof(int), "result");

        private static readonly ParameterExpression[] Parameters =
        {
            Expression.Parameter(typeof (T), "x"),
            Expression.Parameter(typeof (T), "y")
        };

        private ZComparer()
        {

        }

        private ZComparer(BlockExpression value)
        {
            Value = value;
        }

        private BlockExpression Value { get; set; }

        private static BlockExpression GetNewBody<TComparable>(Expression<Func<T, TComparable>> expression, bool negate) where TComparable : IComparable<TComparable>
        {
            string name = expression.ToString();
            if (negate)
                name += "Neg";
            BlockExpression result;
            if (MemberMemoizeDictionary.TryGetValue(name, out result))
            {
                return result;
            }
            result = CreateCompareTo(expression, negate);
            MemberMemoizeDictionary[name] = result;
            return result;
        }

        private static BlockExpression CreateCompareTo<TComparable>(Expression<Func<T, TComparable>> memberExpression, bool negate) where TComparable : IComparable<TComparable>
        {
            var compareTo = GetCompareToExpression(memberExpression, negate);
            ConstantExpression zero = Expression.Constant(0, typeof(int));
            return Expression.Block(new[] { Result },
                Expression.Assign(Result, compareTo),
                Expression.IfThen(Expression.NotEqual(Result, zero),
                    Expression.Return(RetLabelTarget, Result)));
        }


        private static MethodCallExpression GetCompareToExpression<TComparable>(Expression<Func<T, TComparable>> memberExpression, bool negate)
            where TComparable : IComparable<TComparable>
        {
            int leftParam, rightParam;
            if (!negate)
            {
                leftParam = 0;
                rightParam = 1;
            }
            else
            {
                leftParam = 1;
                rightParam = 0;
            }

            var leftSide = GetSideFromExpression(Parameters[leftParam], memberExpression);
            var rightSide = GetSideFromExpression(Parameters[rightParam], memberExpression);
            var compareTo = GetCompareToMethodInfo<TComparable>();
            var compareToCall = Expression.Call(leftSide, compareTo, rightSide);
            return compareToCall;
        }

        private static Expression GetSideFromExpression<TComparable>(ParameterExpression parameter, Expression<Func<T, TComparable>> expression)
            where TComparable : IComparable<TComparable>
        {
            var replace = PredicateRewriterVisitor.Rewrite(expression, parameter);
            return replace.Body;
        }

        private static MethodInfo GetCompareToMethodInfo<TComparable>()
        {
            var type = typeof(TComparable);
            var methods = type.GetMethods().Where(x => x.Name == "CompareTo").ToArray();
            if (methods.Length == 1)
                return methods[0];
            foreach (var info in methods)
            {
                var infoType = info.GetParameters().Select(x => x.ParameterType).Single();
                if (infoType == type)
                    return info;
            }
            throw new Exception("Never throws");
        }

        private static Expression<Comparison<T>> ToExpression(BlockExpression blockExpression)
        {
            return Expression.Lambda<Comparison<T>>(blockExpression, Parameters);
        }

        private BlockExpression AddToCurrentComparer<TComparable>(BlockExpression additionalComparasion) where TComparable : IComparable<TComparable>
        {
            var visitor = new ZComparerBuilderVisitor(additionalComparasion);
            var blockExpression = (BlockExpression)visitor.Visit(Value);
            return blockExpression;
        }


        #endregion

        [NotNull]
        [Pure]
        public static ZComparer<T> New<TComparable>([NotNull] Expression<Func<T, TComparable>> member, bool negate = false) where TComparable : IComparable<TComparable>
        {
            var comparator = new ZComparer<T>();
            var body = GetNewBody(member, negate);
            comparator.Value = body;
            return comparator;
        }

        [NotNull]
        [Pure]
        public static ZComparer<T> NewNeg<TComparable>([NotNull] Expression<Func<T, TComparable>> member) where TComparable : IComparable<TComparable>
        {
            return New(member, true);
        }

        [NotNull]
        [Pure]
        public ZComparer<T> Add<TComparable>([NotNull] Expression<Func<T, TComparable>> member, bool negate = false) where TComparable : IComparable<TComparable>
        {
            var additionalComparasion = GetNewBody(member, negate);
            var blockExpression = AddToCurrentComparer<TComparable>(additionalComparasion);
            return new ZComparer<T>(blockExpression);
        }

        [NotNull]
        [Pure]
        public ZComparer<T> AddNeg<TComparable>([NotNull] Expression<Func<T, TComparable>> member) where TComparable : IComparable<TComparable>
        {
            return Add(member, true);
        }

        [NotNull]
        [Pure]
        public Comparison<T> ToDelegate()
        {
            ConstantExpression zero = Expression.Constant(0, typeof(int));
            var labeled = Expression.Block(Value, Expression.Label(RetLabelTarget, zero));
            var result = ToExpression(labeled);
            return result.Compile();
        }

        [NotNull]
        [Pure]
        public IComparer<T> ToComparer()
        {
            return Comparer<T>.Create(ToDelegate());
        }
    }
}