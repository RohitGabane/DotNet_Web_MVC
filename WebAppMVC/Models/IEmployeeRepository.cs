namespace WebAppMVC.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployee(int Id);
        Employee AddEmp(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Employee DeleteEmployee(int id);

    }
}
