using Demo.BusinessLogic.DTOs.Employees;
using Demo.DataAccess.Entities.Employees;
using Demo.DataAccess.Repositories.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public int? CreateEmployee(EmployeeToCreateDto createEmployeeDTO)
        {
            Employee employee = new Employee()
            {
                Name = createEmployeeDTO.Name,
                Age = createEmployeeDTO.Age,
                Address = createEmployeeDTO.Address,
                IsActive = createEmployeeDTO.IsActive,
                Salary = createEmployeeDTO.Salary,
                Email = createEmployeeDTO.Email,
                PhoneNumber = createEmployeeDTO.PhoneNumber,
                HiringDate = createEmployeeDTO.HiringDate,
                Gender = createEmployeeDTO.Gender,
                EmployeeType = createEmployeeDTO.EmployeeType,
                createdBy = 1, // Assuming a default value for createdBy
                lastModifiedBy = 1, // Assuming a default value for lastModifiedBy
                LastModifiedOn = DateTime.UtcNow,
                DepartmentId = createEmployeeDTO.DepartmentId
            };
            return _employeeRepository.Add(employee); // number of rows affected
        }

        public bool DeleteEmployee(int id)
        {
            var emp = _employeeRepository.GetById(id);
            if (emp is not null)
                return _employeeRepository.Delete(emp) > 0; // number of rows affected
            return false; // Employee not found
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees()
        {
            //return _employeeRepository.GetAll().Where(e => !e.IsDeleted)
            //    .Select(e => new EmployeeDTO
            //    {
            //        Id = e.Id,
            //        Name = e.Name,
            //        Age = e.Age,
            //        Salary = e.Salary,
            //        IsActive = e.IsActive,
            //        Email = e.Email,
            //        Gender = e.Gender.ToString(),
            //        EmployeeType = e.EmployeeType.ToString()
            //    });

            var query = 
            _employeeRepository.GetAllEnumerable()
            .Where(x => !x.IsDeleted)
            .Select(e => new EmployeeDTO
            {
                Id = e.Id,
                Name = e.Name,
                Age = e.Age,
                Email = e.Email,
                Salary = e.Salary,
                Gender = e.Gender.ToString(),
                EmployeeType = e.EmployeeType.ToString(),
                IsActive = e.IsActive,
            });
            var employees = query.ToList();
            var count = query.Count();
            var firstEmployee = query.FirstOrDefault();
            return query;

        }

        public EmployeeDetailsToReturnDto? GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetById(id);
            if (employee is null) return null;

            return new EmployeeDetailsToReturnDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Age = employee.Age,
                Email = employee.Email,
                Salary = employee.Salary,
                Address = employee.Address,
                HiringDate = employee.HiringDate,
                PhoneNumber = employee.PhoneNumber,
                Gender = employee.Gender.ToString(),
                EmployeeType = employee.EmployeeType.ToString(),
                IsActive = employee.IsActive,
                createdBy = employee.createdBy,
                CreatedOn = employee.CreatedOn,
                lastModifiedBy = employee.lastModifiedBy,
                LastModifiedOn = employee.LastModifiedOn,

            };
        }

        public int? Update(EmployeeToUpdateDto updateEmployeeDTO)
        {
            return _employeeRepository.Update(new Employee
            {
                Id = updateEmployeeDTO.Id,
                Name = updateEmployeeDTO.Name,
                Age = updateEmployeeDTO.Age,
                Address = updateEmployeeDTO.Address,
                IsActive = updateEmployeeDTO.IsActive,
                Salary = updateEmployeeDTO.Salary,
                Email = updateEmployeeDTO.Email,
                PhoneNumber = updateEmployeeDTO.PhoneNumber,
                HiringDate = updateEmployeeDTO.HiringDate,
                Gender = updateEmployeeDTO.Gender,
                EmployeeType = updateEmployeeDTO.EmployeeType,
                lastModifiedBy = 1, // Default value or retrieve from current user
                LastModifiedOn = DateTime.UtcNow,
                DepartmentId = updateEmployeeDTO.DepartmentId
            });
        }
    }
}
