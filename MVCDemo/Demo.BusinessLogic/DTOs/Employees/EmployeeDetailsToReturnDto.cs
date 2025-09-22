using Demo.DataAccess.Entities.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.DTOs.Employees
{
    public class EmployeeDetailsToReturnDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public string? Address { get; set; }
        public decimal? Salary { get; set; }
        public bool IsActive { get; set; } = true;
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateOnly HiringDate { get; set; }
        public string Gender { get; set; }
        public string EmployeeType { get; set; }
        public int createdBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int lastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
