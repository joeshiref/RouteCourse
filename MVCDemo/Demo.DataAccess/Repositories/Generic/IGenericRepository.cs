using Demo.DataAccess.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Repositories.Generic
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        int Add(T entity);
        int Delete(T entity);
        IEnumerable<T> GetAll(bool withTracking = false);
        IQueryable<T> GetAllQueryable();
        IEnumerable<T> GetAllEnumerable();
        T? GetById(int id);
        int Update(T entity);
    }
}
