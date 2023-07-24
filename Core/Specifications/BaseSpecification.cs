using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification(Expression<Func<T, bool>> criteria) 
        {
            Criteria = criteria;

        }

        public BaseSpecification()
        {
            
        }
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
        public Expression<Func<T, bool>> Criteria { get; }
        protected void AddInclude(Expression<Func<T, object>> includeExpression) 
        {
            Includes.Add(includeExpression);
        }
    }
}