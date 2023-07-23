namespace WebAppMVC.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        private object employeeChanges;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>(){
            new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@CDACtech.com" },
            new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@CDACtech.com" },
            new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@CDACtech.com" },
            };
        }

        public Employee AddEmp(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
           return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee obj = _employeeList.FirstOrDefault(e=>e.Id==id);
            if(obj != null)
            {
                _employeeList.Remove(obj);
                return obj;
            }
            return obj;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee UpdateEmployee(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
