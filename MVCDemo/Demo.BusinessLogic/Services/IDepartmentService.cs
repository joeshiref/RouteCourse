using Demo.BusinessLogic.DTOs;

namespace Demo.BusinessLogic.Services
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