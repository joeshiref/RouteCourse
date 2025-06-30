using Demo.DataAccess.Contexts;
using Demo.DataAccess.Entities.Employees;
using Demo.DataAccess.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Repositories.Employees
{
    public class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDBContext dbContext) : base(dbContext)
        {
            
        }
    }
}
