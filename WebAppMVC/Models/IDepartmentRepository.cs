namespace WebAppMVC.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartment();
        Department GetDepartment(int Id);

        Department AddDep(Department department);

    }
}
