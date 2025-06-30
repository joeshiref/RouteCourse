using Demo.BusinessLogic.DTOs.Departments;
using Demo.DataAccess.Entities.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.Factories
{
    public static class DepartmentFactory
    {
        public static DepartmentDTO ToDepartmentDTO(this Department department)
        {
            return new DepartmentDTO()
            {
                Code = department.Code,
                Name = department.Name,
                //Description = department.Description,
                DateOfCreation = department.CreatedOn,
                Id = department.Id,
            };
        }
        public static DepartmentDetailedDTO ToDepartmentDetailedDTO(this Department department)
        {
            return new DepartmentDetailedDTO()
            {
                Code = department.Code,
                Name = department.Name,
                Description = department.Description,
                DateOfCreation = department.CreatedOn,
                DeptId = department.Id,
                LastModifiedBy = department.lastModifiedBy,
                IsDeleted = department.IsDeleted,
                CreatedBy = department.createdBy,
                LastModifiedOn = department.LastModifiedOn,
            };
        }
        public static Department ToEntity(this CreateDepartmentDTO createDepartmentDTO)
        {
            return new Department()
            {
                Code = createDepartmentDTO.Code,
                Name = createDepartmentDTO.Name,
                Description = createDepartmentDTO.Description,
                CreatedOn = createDepartmentDTO.CreationDate,
            };
        }
        public static Department ToEntity(this DepartmentToUpdateDto updateDepartmentDTO)
        {
            return new Department()
            {
                Id = updateDepartmentDTO.Id,
                Code = updateDepartmentDTO.Code,
                Name = updateDepartmentDTO.Name,
                Description = updateDepartmentDTO.Description,
                CreatedOn = updateDepartmentDTO.CreationDate,
            };
        }
    }
}
