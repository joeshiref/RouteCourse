using System.Linq.Expressions;

namespace Domain.Contracts
{
    public abstract class Specifications<T> where T : class
    {
        public Expression<Func<T, bool>>? Criteria { get; }
        public List<Expression<Func<T, object>>> Includes { get; } = new();

        public Expression<Func<T, object>> OrderBy { get; private set; }
        public Expression<Func<T, object>> OrderByDesc { get; private set; }

        protected Specifications(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }
        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        protected void SetOrderBy(Expression<Func<T, object>> expression)
        {
            OrderBy = expression;
        }
        protected void SetOrderByDesc(Expression<Func<T, object>> expression)
        {
            OrderByDesc = expression;
        }

    }
}
