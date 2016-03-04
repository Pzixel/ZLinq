using System.Linq.Expressions;

namespace ZLinq.Comparers
{
    /// <summary>
    /// http://stackoverflow.com/questions/8540954/changing-parameter-name-in-a-lambdaexpression-just-for-display
    /// </summary>
    internal class PredicateRewriterVisitor : ExpressionVisitor
    {
        private readonly ParameterExpression _parameterExpression;

        public PredicateRewriterVisitor(ParameterExpression parameterExpression)
        {
            _parameterExpression = parameterExpression;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return _parameterExpression;
        }

        public static Expression<T> Rewrite<T>(Expression<T> exp, ParameterExpression newParam)
        {
            var newExpression = new PredicateRewriterVisitor(newParam).Visit(exp);
            return (Expression<T>) newExpression;
        }
    }
}
