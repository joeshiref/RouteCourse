using Demo.BusinessLogic.DTOs.Departments;

namespace Demo.BusinessLogic.Services.Departments
{
    public interface IDepartmentService
    {
        int? CreateDepartment(CreateDepartmentDTO createDepartmentDTO);
        IEnumerable<DepartmentDTO> GetAllDepartments();
        DepartmentDetailedDTO? GetDepartmentByID(int id);
        int? Update(DepartmentToUpdateDto updateDepartmentDTO);
        int? DeleteDepartment(int id);
    }
}