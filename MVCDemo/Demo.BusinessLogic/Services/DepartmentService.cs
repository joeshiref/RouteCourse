using Demo.BusinessLogic.DTOs;
using Demo.DataAccess.Models;
using Demo.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.Services
{
    public class DepartmentService(IDepartmentRepoistory _departmentRepoistory)
    {
        // Get All Departments
        public IEnumerable<DepartmentDTO> GetAllDepartments()
        {
            var departments = _departmentRepoistory.GetAll();
            var departmentsToReturn = departments.Select(d => new DepartmentDTO()
            {
                Code = d.Code,
                Name = d.Name,
                Description = d.Description,
                DateOfCreation = d.CreatedOn,
                DeptId = d.Id,
            });
            return departmentsToReturn;
        }

        public DepartmentDetailedDTO? GetDepartmentByID(int id)
        {
            var department = _departmentRepoistory.GetByID(id);
            if(department == null)
                return null;
            else
            {
                var departmentToReturn = new DepartmentDetailedDTO()
                {
                    DeptId = department.Id,
                    Name = department.Name,
                    Code = department.Code,
                    Description = department.Description,
                    DateOfCreation = department.CreatedOn,
                    LastModifiedBy = department.lastModifiedBy,
                    IsDeleted = department.IsDeleted,
                    CreatedBy = department.createdBy,
                };
                return departmentToReturn;
            }
        }

    }
}
