using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.DTOs.Departments
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        //public string? Description { get; set; }
        public DateTime? DateOfCreation { get; set; }

    }
}
