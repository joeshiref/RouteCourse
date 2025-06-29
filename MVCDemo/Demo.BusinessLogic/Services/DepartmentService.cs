using Demo.BusinessLogic.DTOs;
using Demo.BusinessLogic.Factories;
using Demo.DataAccess.Models;
using Demo.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.Services
 {
    public class DepartmentService(IDepartmentRepoistory _departmentRepoistory) : IDepartmentService
    {
        // Get All Departments
        public IEnumerable<DepartmentDTO> GetAllDepartments()
        {
            var departments = _departmentRepoistory.GetAll();
            var departmentsToReturn = departments.Select(d => d.ToDepartmentDTO());
            return departmentsToReturn;
        }

        public DepartmentDetailedDTO? GetDepartmentByID(int id)
        {
            var department = _departmentRepoistory.GetByID(id);
            if (department == null)
                return null;
            else
                return department.ToDepartmentDetailedDTO();
        }
        public int? CreateDepartment(CreateDepartmentDTO createDepartmentDTO)
        {
            if (createDepartmentDTO == null)
                return null;
            var department = createDepartmentDTO.ToEntity();
            var result = _departmentRepoistory.Add(department);
            return result;
        }

        public int? Update(DepartmentToUpdateDto updateDepartmentDTO)
        {
            if (updateDepartmentDTO == null)
                return null;
            var department = updateDepartmentDTO.ToEntity();
            var result = _departmentRepoistory.Update(department);
            return result;
        }

        public int? DeleteDepartment(int id)
        {
            var department = _departmentRepoistory.GetByID(id);
            if (department == null)
                return null;
            var result = _departmentRepoistory.Delete(department);
            return result;
        }
    }
}
