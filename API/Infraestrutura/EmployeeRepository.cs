using API.Model;

namespace API.Infraestrutura
{
    public class EmployeeRepository : IEmployeeRepository


    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> get()
        {
            return _context.Employees.ToList();
        }
    }
}
