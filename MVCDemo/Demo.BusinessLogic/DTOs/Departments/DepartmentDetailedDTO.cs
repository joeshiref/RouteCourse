using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.DTOs.Departments
{
    public class DepartmentDetailedDTO
    {
        public int DeptId { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
