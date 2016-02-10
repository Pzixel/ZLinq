using System.Linq.Expressions;

namespace ZLinq.Comparers
{
    internal class ZComparerVisitor : ExpressionVisitor
    {
        public Expression Replacement { get; }
        private bool _canReplace = true;
        public ZComparerVisitor(Expression replacement)
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
