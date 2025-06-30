using Demo.DataAccess.Contexts;
using Demo.DataAccess.Entities.Department;
using Demo.DataAccess.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Repositories.Departments
{
    public class DepartmentRepoistory: GenericRepository<Department>, IDepartmentRepoistory
    {
        public DepartmentRepoistory(AppDBContext dbContext) : base(dbContext)
        {
            
        }
    }
}
