namespace EmployeeManagement.Model.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
