using Demo.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
    {
        private readonly AppDBContext _dbContext;

        public GenericRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // CRUD Operations for T
        // GetAll
        public IEnumerable<T> GetAll(bool withTracking = false)
        {
            // IsDeleted == false ==> not deleted [appear for user]
            if (withTracking)
            {
                return _dbContext.Set<T>().Where(x => !x.IsDeleted).ToList();
            }
            return _dbContext.Set<T>().Where(x => !x.IsDeleted).AsNoTracking().ToList();
        }
        // GetByID
        public T? GetById(int id)
        {
            var T = _dbContext.Set<T>().Find(id);
            return T;
        }
        // Add
        public int Add(T T)
        {
            _dbContext.Set<T>().Add(T);
            return _dbContext.SaveChanges();
        }
        // Edit
        public int Update(T T)
        {
            _dbContext.Set<T>().Update(T);
            return _dbContext.SaveChanges();
        }
        // Delete
        public int Delete(T T)
        {
            //_dbContext.Set<T>().Remove(T);
            //return _dbContext.SaveChanges();
            // IsDeleted == true ==> deleted [disappear for user]
            T.IsDeleted = true;
            _dbContext.Set<T>().Update(T);
            return _dbContext.SaveChanges();

        }
    }
}
