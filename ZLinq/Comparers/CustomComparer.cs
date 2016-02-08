using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace ZLinq.Comparers
{
    [SuppressMessage("ReSharper", "StaticMemberInGenericType")]
    public sealed class CustomComparer<T>
    {
        private static readonly Dictionary<string, BlockExpression> MemberMemoizeDictionary = new Dictionary<string, BlockExpression>();
        private static readonly LabelTarget RetLabelTarget = Expression.Label(typeof (int));

        private static readonly ParameterExpression[] Parameters =
        {
            Expression.Parameter(typeof (T), "x"),
            Expression.Parameter(typeof (T), "y")
        };

        private CustomComparer()
        {

        }

        private BlockExpression Value { get; set; }

        private static BlockExpression CreateBody<TProperty>(CustomComparer<T> comparer, Expression<Func<T, TProperty>> member, bool negate)
            where TProperty : IComparable<TProperty>, IComparable
        {
            MemberExpression memberExpression = member.Body as MemberExpression;
            if (memberExpression == null)
            {
                negate = true;
                memberExpression = (MemberExpression) ((UnaryExpression) member.Body).Operand;
            }
            BlockExpression result = comparer.GetCompareTo<TProperty>(negate, memberExpression);
            return result;
        }

        private BlockExpression GetCompareTo<TProperty>(bool negate, MemberExpression memberExpression) where TProperty : IComparable<TProperty>, IComparable
        {
            string name = memberExpression.Member.Name;
            if (negate)
                name += "Neg";
            BlockExpression result;
            if (MemberMemoizeDictionary.TryGetValue(name, out result))
            {
                return result;
            }
            result = CreateCompareTo<TProperty>(memberExpression, negate);
            MemberMemoizeDictionary[name] = result;
            return result;
        }

        private BlockExpression CreateCompareTo<TProperty>(MemberExpression memberExpression, bool negate) where TProperty : IComparable<TProperty>, IComparable
        {
            var compareTo = GetCompareToExpression<TProperty>(memberExpression);
            var compareToVariable = compareTo.Key;
            var compareToCall = compareTo.Value;
            ConstantExpression zero = Expression.Constant(0, typeof (int));
            return Expression.Block(new[] {compareToVariable},
                Expression.Assign(compareToVariable, compareToCall),
                Expression.IfThen(Expression.NotEqual(compareToVariable, zero),
                    Expression.Return(RetLabelTarget, negate ? Expression.Negate(compareToVariable) : (Expression) compareToVariable)));
        }


        private static KeyValuePair<ParameterExpression, MethodCallExpression> GetCompareToExpression<TProperty>(MemberExpression memberExpression)
            where TProperty : IComparable<TProperty>, IComparable
        {
            var member = memberExpression.Member;
            var prop0 = Expression.PropertyOrField(Parameters[0], member.Name);
            var prop1 = Expression.PropertyOrField(Parameters[1], member.Name);
            var compareTo = GetCompareToMethodInfo<TProperty>();
            var compareToCall = Expression.Call(prop0, compareTo, prop1);
            var parameterExpression = Expression.Variable(typeof (int), "compare" + member.Name);
            return new KeyValuePair<ParameterExpression, MethodCallExpression>(parameterExpression, compareToCall);
        }

        private static MethodInfo GetCompareToMethodInfo<TProperty>()
        {
            var type = typeof (TProperty);
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

        public static CustomComparer<T> New<TProperty>(Expression<Func<T, TProperty>> member) where TProperty : IComparable<TProperty>, IComparable
        {
            var comparator = new CustomComparer<T>();
            var body = CreateBody(comparator, member, false);
            comparator.Value = body;
            return comparator;
        }

        public CustomComparer<T> Add<TProperty>(Expression<Func<T, TProperty>> member) where TProperty : IComparable<TProperty>, IComparable
        {
            var additionalComparasion = CreateBody(this, member, false);
            var visitor = new CustomComparerVisitor(additionalComparasion);
            Value = (BlockExpression) visitor.Visit(Value);
            return this;
        }

        public static CustomComparer<T> NewNeg<TProperty>(Expression<Func<T, TProperty>> member) where TProperty : IComparable<TProperty>, IComparable
        {
            var comparator = new CustomComparer<T>();
            var body = CreateBody(comparator, member, true);
            comparator.Value = body;
            return comparator;
        }

        public CustomComparer<T> AddNeg<TProperty>(Expression<Func<T, TProperty>> member) where TProperty : IComparable<TProperty>, IComparable
        {
            var additionalComparasion = CreateBody(this, member, true);
            var visitor = new CustomComparerVisitor(additionalComparasion);
            Value = (BlockExpression) visitor.Visit(Value);
            return this;
        }

        public static explicit operator Expression<Comparison<T>>(CustomComparer<T> obj)
        {
            return ToExpression(obj.Value);
        }

        private static Expression<Comparison<T>> ToExpression(BlockExpression blockExpression)
        {
            return Expression.Lambda<Comparison<T>>(blockExpression, Parameters);
        }

        public Comparison<T> ToDelegate()
        {
            ConstantExpression zero = Expression.Constant(0, typeof (int));
            var labeled = Expression.Block(Value, Expression.Label(RetLabelTarget, zero));
            var result = ToExpression(labeled);
            return result.Compile();
        }

        public IComparer<T> ToComparer()
        {
            return Comparer<T>.Create(ToDelegate());
        }
    }
}