using Demo.DataAccess.Entities.Department;
using Demo.DataAccess.Entities.Employees;
using Demo.DataAccess.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Repositories.Employees
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        
    }
}
