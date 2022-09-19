using TestBlazor2022_Models;

namespace TestBlazor2022_Api
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
