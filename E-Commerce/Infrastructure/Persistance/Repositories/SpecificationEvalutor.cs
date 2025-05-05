using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    internal static class SpecificationEvalutor
    {
        public static IQueryable<T> GetQuery<T>(IQueryable<T>inputQuery, Specifications<T>specifications) where T : class
        {
            var query = inputQuery;
            if (specifications.Criteria != null)
            {
                query = query.Where(specifications.Criteria);
            }

            query = specifications.Includes.Aggregate(query, (currentQuery, includeExpression) => currentQuery.Include(includeExpression));
            if (specifications.OrderBy != null)
            {
                query = query.OrderBy(specifications.OrderBy);
            }
            else if (specifications.OrderByDesc != null)
            {
                query = query.OrderByDescending(specifications.OrderByDesc);
            }
                return query;


        }

    }
}
