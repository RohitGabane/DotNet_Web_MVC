namespace WebAppMVC.Models
{
    public class MockDepartmentRepository : IDepartmentRepository
    {
        private List<Department> _DepartmentList;

        public MockDepartmentRepository()
        {
            _DepartmentList = new List<Department>(){
            new Department() { Id = 1, Name = "Hr" },
            new Department() { Id = 2, Name = "It"},
            new Department() {Id = 3, Name = "Sam"},
            };
        }

        public Department AddDep(Department department)
        {
            department.Id = _DepartmentList.Max(e => e.Id) + 1;
            _DepartmentList.Add(department);
            return department;
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return _DepartmentList;

        }

        public Department GetDepartment(int Id)
        {
            return _DepartmentList.FirstOrDefault(e => e.Id == Id);

        }
    }
}
