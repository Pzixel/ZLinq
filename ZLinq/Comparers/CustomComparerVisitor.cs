using System.Linq.Expressions;

namespace ZLinq.Comparers
{
    internal class CustomComparerVisitor : ExpressionVisitor
    {
        public Expression To { get; set; }
        private bool _canReplace = true;
        public CustomComparerVisitor(Expression to)
        {
            To = to;
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            DefaultExpression de = node.IfFalse as DefaultExpression;

            if (de != null && de.Type == typeof(void) && _canReplace)
            {
                _canReplace = false;
                return Visit(Expression.IfThenElse(node.Test, node.IfTrue, To));
            }

            return base.VisitConditional(node);
        }
    }
}
