using Demo.BusinessLogic.DTOs.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.Services.Employees
{
    public interface IEmployeeService
    {
        int? CreateEmployee(EmployeeToCreateDto createEmployeeDTO);
        IEnumerable<EmployeeDTO> GetAllEmployees();
        EmployeeDetailsToReturnDto? GetEmployeeById(int id);
        int? Update(EmployeeToUpdateDto updateEmployeeDTO);
        bool DeleteEmployee(int id);
    }
}
