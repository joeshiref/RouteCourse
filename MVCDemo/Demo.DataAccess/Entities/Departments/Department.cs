using Demo.DataAccess.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Entities.Department
{
    public class Department : BaseEntity
    {
        public required string Name { get; set; }
        public string Code { get; set; } = null!;

        public string? Description { get; set; }

        public DateOnly CreationDate { get; set; }

        // Navigational properties [Many]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();



    }
}
