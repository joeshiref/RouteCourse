
namespace Demo.DataAccess.Repositories
{
    public interface IDepartmentRepoistory
    {
        int Add(Department department);
        int Delete(Department department);
        IEnumerable<Department> GetAll(bool withTracking = false);
        Department? GetByID(int id);
        int Update(Department department);
    }
}