using System.Linq.Expressions;

namespace ZLinq.Comparers
{
    internal class ZComparerBuilderVisitor : ExpressionVisitor
    {
        public Expression Replacement { get; }
        private bool _canReplace = true;
        public ZComparerBuilderVisitor(Expression replacement)
        {
            Replacement = replacement;
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            DefaultExpression defaultExpression = node.IfFalse as DefaultExpression;

            if (defaultExpression == null || defaultExpression.Type != typeof (void) || !_canReplace)
                return base.VisitConditional(node);

            _canReplace = false;    
            return Visit(Expression.IfThenElse(node.Test, node.IfTrue, Replacement));
        }
    }
}
