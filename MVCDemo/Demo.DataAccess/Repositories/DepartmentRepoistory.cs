using Demo.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Repositories
{
    public class DepartmentRepoistory(AppDBContext dbContext) : IDepartmentRepoistory
    {
        private readonly AppDBContext _dbContext = dbContext;

        // CRUD Operations for department
        // GetAll
        public IEnumerable<Department> GetAll(bool withTracking = false)
        {
            if (withTracking)
            {
                return _dbContext.Departments.ToList();
            }
            return _dbContext.Departments.AsNoTracking().ToList();
        }
        // GetByID
        public Department? GetByID(int id)
        {
            var department = _dbContext.Departments.Find(id);
            return department;
        }
        // Add
        public int Add(Department department)
        {
            _dbContext.Departments.Add(department);
            return _dbContext.SaveChanges();
        }
        // Edit
        public int Update(Department department)
        {
            _dbContext.Departments.Update(department);
            return _dbContext.SaveChanges();
        }
        // Delete
        public int Delete(Department department)
        {
            _dbContext.Departments.Remove(department);
            return _dbContext.SaveChanges();

        }
    }
}
